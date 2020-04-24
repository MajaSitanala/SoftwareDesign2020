using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace V3_Parallel_ForEach
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

            // Laver en liste af objekt til at indeholde værdierne:
            List<ABC> aBCs = new List<ABC>();

            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next();
                B[i] = rand.Next();
                C[i] = rand.Next();

                // Opretter objekter med de samme værdier og ligger dem ind listen af objekter:
                ABC abc1 = new ABC();
                abc1.A = A[i];
                abc1.B = B[i];
                abc1.C = C[i];
                aBCs.Add(abc1);
            }


            // Køre eksperimentet 10 gange for at se på den "sande tid" fordi der godt kan køre flere
            // paralelle processer på computeren som kan inflyde målingen, derfor sammenlignes der flere
            // tider for at undgå fejlmålinger.
            List<long> timestamps = new List<long>();
            for(int e= 0; e < 10; e++)
            {
                Console.WriteLine("Starts ForEach for now.");
                stopwatch.Start();

                Parallel.ForEach(aBCs, arg =>
                {
                    arg.C = arg.A * arg.B;
                });

                stopwatch.Stop();
                Console.WriteLine("ForEach loop time in milliseconds: {0}", stopwatch.ElapsedMilliseconds);
                timestamps.Add(stopwatch.ElapsedMilliseconds);
                stopwatch.Reset();
                Console.WriteLine("Finished");
            }
            // Finds the mean time minus the first sample
            timestamps.RemoveAt(0);
            Console.WriteLine("Mean time (minus first sample): {0}", timestamps.Average());



        }

        // Objekt til at indeholde ærdierne som skal sammenlignes.
        public class ABC
        {
            public double A;
            public double B;
            public double C;
        }
    }
}
