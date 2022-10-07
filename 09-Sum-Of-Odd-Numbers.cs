using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
           int n = int.Parse(Console.ReadLine());
           int sum = 0;
           int startNumber = 1;
           
           while (n > 0)
           {
               Console.WriteLine(startNumber);
               sum += startNumber;
               startNumber += 2;
               n--;
           }
           
           Console.WriteLine($"Sum: {sum}");
        }
    }
}