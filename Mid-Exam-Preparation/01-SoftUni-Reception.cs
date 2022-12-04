using System;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int empl1 = int.Parse(Console.ReadLine());
            int empl2 = int.Parse(Console.ReadLine());
            int empl3 = int.Parse(Console.ReadLine());
            int inputCount = int.Parse(Console.ReadLine());
            
            int allEmployee = empl1 + empl2 + empl3;
            int res = inputCount / allEmployee;
            
            if (res * allEmployee < inputCount)
            {
                res++;
            }
            
            int breakHours = res / 3;
            if (breakHours > 0)
            {
                res = res + breakHours;
            }
            
            Console.WriteLine($"Time needed: {res}h.");
        }
    }
}
