using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            Console.WriteLine(GetMiddleCharacters(input));
        }
        
        static string GetMiddleCharacters(string input)
        {
            string result = "";
            
            if (input.Length % 2 != 0)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            
            return result;
        }
    }
}
