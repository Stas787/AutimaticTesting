using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NumberOfSymbolsCounter
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the string ");
            string enterString = Console.ReadLine();
            List<int> results = new List<int>();
            StringBuilder subStrings = new StringBuilder();

            for (int i = 0; i < enterString.Length; i++)
            {
                subStrings.Append(enterString[i]);

                for (int j = 0; j < subStrings.Length - 1; j++)
                {
                    if (subStrings[^1] == subStrings[j])
                    {
                        results.Add(subStrings.Length - 1);
                        subStrings.Clear();
                        subStrings.Append(enterString[i]);
                    }
                }

                if (i == enterString.Length - 1)
                {
                    results.Add(subStrings.Length);
                }
            }

            Console.WriteLine($"Result: {results.Max()}");
        }
    }
}