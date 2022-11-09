using System;
using System.Linq;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
 
            while (input != "end")
            {
                var reversedString = input.ToArray().Reverse();
    
                Console.WriteLine($"{input} = {string.Join("",reversedString)}");
                
                input = Console.ReadLine();
            }
        }
    }
}
