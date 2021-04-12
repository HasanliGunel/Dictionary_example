using System;
using System.Linq;

namespace Dictionary_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = new string[]
            {
                "One",
                "Two",
                "Three"
            };
            var result = values.ToDictionary(item => item, item => true);
            foreach (var pair in result)
                Console.WriteLine("Result pair {0}, {1}", pair.Key, pair.Value);
        }
    }
}
