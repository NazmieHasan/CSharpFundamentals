using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
 
            var counts = new Dictionary<string, int>();
 
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }
 
            var results = new List<string>();
 
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    results.Add(count.Key);
                }
            }
            
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
