using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
           
            switch (operation) 
            {
                case "+":
                    Add(a, b);
                    break;
                case "*":
                    Multiply(a, b);
                    break; 
                case "-":
                    Substract(a, b);
                    break;
                default:
                    Divide(a, b);
                    break; 
            }
           
        }
        
        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);   
        }
        
        static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);   
        }
        
        static void Substract(double a, double b)
        {
            Console.WriteLine(a - b);   
        }
        
        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);   
        }
    }
}
