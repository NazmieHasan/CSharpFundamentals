using System;
using System.Text;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char previousChar = text[0];
            Console.Write(previousChar);
            
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (previousChar != currentChar)
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            } 
        }
    }
}
