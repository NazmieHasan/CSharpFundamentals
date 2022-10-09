using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double result = num * 1.31;
            
            Console.WriteLine($"{result:F3}");
        }
    }
}
