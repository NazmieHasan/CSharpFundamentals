using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            double sum = MathPower(number, power);
            Console.WriteLine(sum);
        }
        
        static double MathPower(double number, int power)
        {
            double result = 1;
            
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return  result;
        }
    }
}
