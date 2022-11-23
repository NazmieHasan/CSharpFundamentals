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
            
            Console.WriteLine(AddAndSubtractSum(a, b, c));
        }
        
        static int AddAndSubtractSum(int a, int b, int c)
        {
            return a + b - c;
        }
    }
}
