using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix(number);
        }
      
        static void PrintMatrix(int number)
        { 
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
