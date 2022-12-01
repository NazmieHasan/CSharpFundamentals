using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
 
            int n = int.Parse(Console.ReadLine());
 
            Regex barcodeRegex = new Regex(pattern);
            Regex productGroupRegex = new Regex(@"\d+");
 
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
 
                var match = barcodeRegex.Match(input);
 
                if (match.Success)
                {
                    MatchCollection productGroupMatch = productGroupRegex.Matches(match.Value);
 
                    if (productGroupMatch.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", productGroupMatch)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
