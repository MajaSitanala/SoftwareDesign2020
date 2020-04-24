using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace V2_MyParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            const int N = 40000000; // changed from: const long N
            double[] A, B, C;
            A = new double[N];
            B = new double[N];
            C = new double[N];


            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next();
                B[i] = rand.Next();
                C[i] = rand.Next();
            }

            // Køre eksperimentet 10 gange for at se på den "sande tid" fordi der godt kan køre flere
            // paralelle processer på computeren som kan inflyde målingen, derfor sammenlignes der flere
            // tider for at undgå fejlmålinger.
            List<long> timestamps = new List<long>();
            int sampleCnt = 25;

            for (int e = 0; e < sampleCnt; e++)
            {

                Console.WriteLine("Starts MyParallelFor now.");
                stopwatch.Start();
                MyParallelFor_01(0, N, i =>
                {
                    C[i] = A[i] * B[i];
                });

                stopwatch.Stop();
                Console.WriteLine("MyParallelFor loop time in milliseconds: {0}", stopwatch.ElapsedMilliseconds);
                timestamps.Add(stopwatch.ElapsedMilliseconds);
                stopwatch.Reset();
                Console.WriteLine("Finished");

            }
            // Finds the mean time minus the first sample
            timestamps.RemoveRange(0, 2);
            Console.WriteLine("\nRan {0} times. Deleteting first tre samples", sampleCnt);
            Console.WriteLine("Mean time : {0}", timestamps.Average());
            Console.WriteLine("Highest time : {0}", timestamps.Max());
            Console.WriteLine("Lowest time : {0}", timestamps.Min());

        }


        // M Y P A R A L L E L F O R :     I N I T I A L
        // From the document Patterns_of_Parallel_Programming_CSharp page 5 and 6.
        #region explanitory text
        /*
         * P O S I T I V E S:
         * The primary positive to this approach is that we have dedicated threading
         * resources for this loop, and it is up to the operating system to provide 
         * fair scheduling for these threads across the system.
         * 
         * N E G A T I V E S:
         * * The Cost of thread: read page 6.
         * * Oversubscription: read page 7.
         */
        #endregion explanitory text
        public static void MyParallelFor_01(
        int inclusiveLowerBound, int exclusiveUpperBound, Action<int> body)
        {
            // Determine the number of iterations to be processed, the number of
            // cores to use, and the approximate number of iterations to process
            // in each thread.
            int size = exclusiveUpperBound - inclusiveLowerBound;
            int numProcs = Environment.ProcessorCount;
            int range = size / numProcs;
            // Use a thread for each partition. Create them all,
            // start them all, wait on them all.
            var threads = new List<Thread>(numProcs);
            for (int p = 0; p < numProcs; p++)
            {
                int start = p * range + inclusiveLowerBound;
                int end = (p == numProcs - 1) ?
                exclusiveUpperBound : start + range;
                threads.Add(new Thread(() => {
                    for (int i = start; i < end; i++) body(i);
                }));
            }
            foreach (var thread in threads) thread.Start();
            foreach (var thread in threads) thread.Join();
        }
    }
}
