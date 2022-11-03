using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<double, int> numberOcc = new SortedDictionary<double, int>();
            
            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
                
            foreach (var currentNumber in inputNumbers)
            {
                if (!numberOcc.ContainsKey(currentNumber))
                {
                    numberOcc.Add(currentNumber, 0);
                }
                
                numberOcc[currentNumber] += 1;
            }
            
            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
