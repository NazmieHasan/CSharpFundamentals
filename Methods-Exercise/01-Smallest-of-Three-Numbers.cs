using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(SmallestNumber(a, b, c));
        }
        
        static int SmallestNumber(int a, int b, int c)
        {
            int smallestNumber;
            int currentSmallestNumber = Math.Min(a, b);
            
            if (currentSmallestNumber > c)
            {
                smallestNumber = c;
            }
            else
            {
                smallestNumber = currentSmallestNumber;
            }
            
            return smallestNumber;
        }
    }
}
