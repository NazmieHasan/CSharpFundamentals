using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= number; i++)
            {
                PrintColumns(i);
            }
            
            for (int i = number - 1; i >= 1; i--)
            {
                PrintColumns(i);
            }
        }
        
        static void PrintColumns(int i)
        {
            for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
            Console.WriteLine();
        }
    }
}
