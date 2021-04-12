using System;
using System.Collections.Generic;

namespace Dictionary__remove_elements_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1123, "Welcome");
            dict1.Add(1124, "to");
            dict1.Add(1125, "My proqram");

            foreach (KeyValuePair<int, string> ele1 in dict1)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            dict1.Remove(1123);

            foreach (KeyValuePair<int, string> ele1 in dict1)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
        }
    }
}
