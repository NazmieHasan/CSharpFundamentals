using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                char currCh = char.Parse(Console.ReadLine());
                sum += (int)currCh;
            }
            
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
