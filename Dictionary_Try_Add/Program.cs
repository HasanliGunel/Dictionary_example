using System;
using System.Collections.Generic;

namespace Dictionary_Try_Add
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            bool result = items.TryAdd("test", 1);
            Console.WriteLine("Added:" + result);
            bool result1 = items.TryAdd("test", 2);
            Console.WriteLine("Added:" + result1);
            Console.WriteLine(items.GetValueOrDefault("test"));
        }
    }
}
