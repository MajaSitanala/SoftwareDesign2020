using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lab12ParralelLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            const long N = 40000000;
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
                Console.WriteLine("Starts sequential for now.");
                stopwatch.Start();
                for (int i = 0; i < N; i++)
                {
                    C[i] = A[i] * B[i];
                }
                stopwatch.Stop();
                Console.WriteLine("Sequential loop time in milliseconds: {0}", stopwatch.ElapsedMilliseconds);
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
    }
}
