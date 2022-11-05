using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, int> occurances = new Dictionary<char, int>();
            
            string text = Console.ReadLine();
            
            foreach (char ch in text)
            {
                if (ch != ' ')
                {
                    if (!occurances.ContainsKey(ch))
                    {
                        occurances[ch] = 0;
                    }
                    
                    occurances[ch]++;
                } 
            }
            
            foreach (var occurance in occurances)
            {
                Console.WriteLine($"{occurance.Key} -> {occurance.Value}");
            }
        }
    }
}
