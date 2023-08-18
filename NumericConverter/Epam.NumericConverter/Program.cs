using System;
using System.Text;

namespace Epam.NumericConverter
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Radix : ");
            int numericBase = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {ConvertToBase(number, numericBase)}");
        }

        /// <summary>
        /// Convert number to numric system 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numericSystem"></param>
        /// <returns></returns>
        private static string ConvertToBase (int number, int numericSystem)
        {
            while (numericSystem > 20 || numericSystem < 2)
            {
                Console.WriteLine("Base must be from 2 to 20");
                numericSystem = int.Parse(Console.ReadLine());
            }            

            if (numericSystem == 16 || numericSystem == 2 || numericSystem == 10 || numericSystem == 8)
            {
                return Convert.ToString(number, numericSystem);
            }
            else
            {
                StringBuilder result = new StringBuilder();
                while (number != 0)
                {
                    int remainder = number % numericSystem;
                    StringBuilder remainderToAppend = new StringBuilder(remainder.ToString()); 
                    result = remainderToAppend.Append(result);
                    number = number / numericSystem;
                }

                return result.ToString();
            }            
        }
    }
}
