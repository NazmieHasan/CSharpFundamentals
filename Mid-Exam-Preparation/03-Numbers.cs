using System;
using System.Linq;
using System.Collections.Generic;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList(); 
                
            List<int> resNumbers = new List<int>(); 
            
            double averageNum = numbers.Average();
            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNum )
                {
                    resNumbers.Add(numbers[i]);
                }
            }
            
            if (resNumbers.Count > 0)
            {
                resNumbers.Sort();
                resNumbers.Reverse();
              
                if (resNumbers.Count > 5)
                {
                    List<int> resNumbersTopEl = resNumbers.GetRange(0, 5);
                    Console.WriteLine(string.Join(" ", resNumbersTopEl));
                }
                else
                {
                    Console.WriteLine(string.Join(" ", resNumbers));
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
