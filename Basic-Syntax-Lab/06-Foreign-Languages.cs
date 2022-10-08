using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string language = Console.ReadLine();
            
            switch (language)
            {
                case "USA":
                case "England":
                Console.WriteLine("English");
                break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                Console.WriteLine("Spanish");
                break;
                default:
                Console.WriteLine("unknown");
                break;
            }
        }
    }
}
