﻿using System;

namespace Del02
{
    class Program
    {
        public static Func<int, bool> isIndex(int n)
        {
            return x => x != n;
        }

        static void Main(string[] args)
        {
            // Tests:
            var list1 = List<int>.Init(new int[] { 1, 2, 3, 4, 5 });

            var list2 = List<int>.SetHead(list1, 0);

            var list3 = List<int>.Drop(list2, 3);

            var list4 = List<int>.DropWhile(list2, a => a != 2);

            Console.WriteLine("Hello World!");
        }
    }
}
