using System;
using System.Collections.Generic;

namespace Dictionary__Get_Value_Or_Default
{
    class Program
    {
        static void Main(string[] args)
        {
            var cats = new Dictionary<string, int>() { { "mittens", 5 } };
           
            Console.WriteLine(cats.GetValueOrDefault("mittens"));
           
            Console.WriteLine(cats.GetValueOrDefault("?"));
        }
    }
}
