using System;
using System.Collections.Generic;

namespace Dictionary_availability_of_elements_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(1123, "Welcome");
            dict1.Add(1124, "to");
            dict1.Add(1125, "My proqram");

            if (dict1.ContainsKey(1122) == true)
                Console.WriteLine("Key is found!");
            else
                Console.WriteLine("Key is not found!");

            if (dict1.ContainsValue("My proqram") == true)
                Console.WriteLine("Value is found!");
            else
                Console.WriteLine("Value is not found!");

        }
    }
}
