using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            
            for (int i = 0; i < n; i++ )
            {
                decimal inputNumber = decimal.Parse(Console.ReadLine());
                sum += inputNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
