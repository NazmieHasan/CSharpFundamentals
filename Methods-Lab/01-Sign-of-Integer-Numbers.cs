using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            PrintSigh(int.Parse(Console.ReadLine()));
        }
        
        static void PrintSigh(int number)
        {
            if (number > 0)
                Console.WriteLine("The number {0} is positive.", number);
            else if (number < 0)
                Console.WriteLine("The number {0} is negative.", number); 
            else 
                Console.WriteLine("The number {0} is zero.", number);     
        }
    }
}
