using System;
using System.Collections.Generic;

namespace Dictionary_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Dictionary<int, int>();
            test[20] = 30;

            var copy = new Dictionary<int, int>(test);
            copy[30] = 40;
            Console.WriteLine("Test count: {0}", test.Count);
            Console.WriteLine("Copy count: {0}", copy.Count);
            //Console.WriteLine("Test [20]= {0}", test[20]);
            //Console.WriteLine("Copy [20]= {0}\n Copy [30]={1}", copy[20], copy[30]);

        }
    }
}
