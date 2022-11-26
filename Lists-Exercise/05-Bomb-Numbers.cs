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
                .Split()
                .Select(int.Parse)
                .ToList();
                
            List<int> bombPowers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
 
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombPowers[0])
                {
                    for (int j = 1; j <= bombPowers[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                    }
 
                    for (int j = 1; j <= bombPowers[1]; j++)
                    {
                        if (i + j > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + j] = 0;
                        }
                    }
 
                    numbers[i] = 0;
                }
            }
 
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
