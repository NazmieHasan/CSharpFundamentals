using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n]; 
            
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }
            
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
