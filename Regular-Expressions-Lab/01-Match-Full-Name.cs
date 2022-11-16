using System;
using System.Text.RegularExpressions;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            
            foreach (Match item in matchCollection)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
