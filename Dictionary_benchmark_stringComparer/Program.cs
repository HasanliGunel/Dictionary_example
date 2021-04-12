using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Dictionary_benchmark_stringComparer
{
    class Program
    {
        const int max = 10000000;
        static void Main(string[] args)
        {
            var data1 = new Dictionary<string, bool>();
            data1["Las Vegas"] = true;

            var data2 = new Dictionary<string, bool>(StringComparer.Ordinal);
            data2["Las Vegas"] = true;

            Stopwatch s1 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++) ;
            {
                if (!data1.ContainsKey("Las Vegas"))
                {
                    return;
                }
            }
            s1.Stop();

            Stopwatch s2 = Stopwatch.StartNew();
            for (int i = 0; i < max; i++)
            {
                if (!data1.ContainsKey("Las Vegas"))
                {
                    return;
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));


        }
    }
}
