using System;
using System.Linq;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string encryptedString = string.Empty;
            
            foreach (char currentChar in input)
            {
                int currentPosition = currentChar;
                currentPosition += 3;
                encryptedString += (char)currentPosition;
            }
           
            Console.WriteLine(encryptedString);
        }
    }
}
