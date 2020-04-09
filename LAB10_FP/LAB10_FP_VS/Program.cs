using System;

namespace LAB10_FP_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            Arabic arabic = new Arabic(14);
            string a = arabic.ToRoman();
            Console.WriteLine("_"+a+"_");
        }
    }
}
