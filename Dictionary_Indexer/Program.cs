using System;
using System.Collections.Generic;

namespace Dictionary_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[1] = 2;
            dict[2] = 1;
            dict[1] = 3;
            Console.WriteLine(dict[1]);
            Console.WriteLine(dict[2]);
           

        }
    }
}
