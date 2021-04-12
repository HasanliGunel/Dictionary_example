using System;
using System.Collections.Generic;

namespace Dictionary_example
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

            Dictionary<string, string> My_dict2 = new Dictionary<string, string>()
            {
                {"a.1", "Dog"},
                {"a.2", "Cat"},
                {"a.3", "Pig"}
            };

            foreach (KeyValuePair<string, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }
            // Console.WriteLine(My_dict2.GetValueOrDefault("a.1"));
            Console.WriteLine(My_dict2.GetValueOrDefault("?"));

        }
    }
}
