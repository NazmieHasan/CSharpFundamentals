using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            double kms = meters / 1000.0f;
            
            Console.WriteLine($"{kms:F2}");
        } 
    }
}
