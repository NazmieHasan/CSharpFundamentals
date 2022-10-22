using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            List<string> games = Console.ReadLine() 
                .Split(" ")
                .ToList();
            
            string command = Console.ReadLine();
            int count = 0;
            int successCount = 0;
            bool isMatch = false;
            List<string> matchElements = new List<string>();
            
            while (command != "end")
            {
                string[] cmdArgs = command.Split(" ");
                int firstIndex = int.Parse(cmdArgs[0]); 
                int secondIndex = int.Parse(cmdArgs[1]);
                
                string firstValue = games[firstIndex];
                string secondValue = games[secondIndex];
                
                if (firstValue == secondValue) 
                {
                    isMatch = true;
                    successCount++;
                    matchElements.Add(firstValue);
                }
                
                for (int i = 0; i < games.Count; i++)
                {
                    if (isMatch) 
                    {
                        games.RemoveAll(el => el == firstValue);
                    }
                }
                
                count++;
                
                command = Console.ReadLine();
            }
            
            if (games.Count > 0)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"Try again!");
                }
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", games));
            }
            
            else
            {
            
            foreach (string el in matchElements)
            {
                Console.WriteLine($"Congrats! You have found matching elements - {el}!");
            }
            Console.WriteLine($"You have won in {successCount} turns!");
            }
        }
    }
}
