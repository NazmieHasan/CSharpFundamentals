using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int absValue = Math.Abs(int.Parse(input));
            int sumOfEvenDigits = getSumOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = getSumOfOddDigits(absValue.ToString());
            
            int result = sumOfEvenDigits * sumOfOddDigits;
            Console.WriteLine(result);
            
        }
        
        static int getSumOfEvenDigits(string input)
        {
            int sum = 0;
            
            for(int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i].ToString());
                
                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            
            return sum;
        }
        
        static int getSumOfOddDigits(string input)
        {
            int sum = 0;
            
            for(int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i].ToString());
                
                if (currentNumber % 2 != 0)
                {
                    sum += currentNumber;
                }
            }
            
            return sum;
        }
        
    }
}
