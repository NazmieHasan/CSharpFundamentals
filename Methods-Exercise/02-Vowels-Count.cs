using System;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }
        
        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = {'a', 'e', 'o', 'u', 'i'};
            
            foreach (char letter in text.ToLower())
            
            if (vowels.Contains(letter))
            {
                vowelsCount++;
            }
            
            return vowelsCount;
        }
    }
}
