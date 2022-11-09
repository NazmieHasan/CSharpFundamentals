using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            
            foreach (var currentBannedWord in bannedWords)
            {
                text = text.Replace(currentBannedWord, new string('*', currentBannedWord.Length));
            }
            
            Console.WriteLine(text);
        }
    }
}
