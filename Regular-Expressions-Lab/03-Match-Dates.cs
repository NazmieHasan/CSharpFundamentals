using System;
using System.Text.RegularExpressions;
using System.Linq;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            
            foreach (Match match in matchCollection)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            } 
        }
    }
}
