using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
           
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            
            long firstResult = (long)num1 + num2;
            long secondResult = firstResult / num3;
            long finalResult = secondResult * num4;
            
            Console.WriteLine(finalResult);
        }
    }
}
