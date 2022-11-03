using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                
                if (!synonyms.ContainsKey(word)) 
                {
                    synonyms.Add(word, new List<string>());
                }
                
                synonyms[word].Add(synonym);
            }
            
            
            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
           
        }
    }
}
