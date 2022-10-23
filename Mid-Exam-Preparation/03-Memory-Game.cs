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
            bool isValidIndex = false;
            int count = 0;
            int successCount = 0;
            string currentMachValue = "";
            
            while (command != "end")
            {
                string[] cmdArgs = command.Split(" ");
                int firstIndex = int.Parse(cmdArgs[0]); 
                int secondIndex = int.Parse(cmdArgs[1]);
                
                count++;
                
                if (firstIndex >= 0 && firstIndex < games.Count && secondIndex >= 0 && secondIndex < games.Count && firstIndex != secondIndex)
                {
                    isValidIndex = true;
                }
                 
                if (isValidIndex)
                {
                
                    string firstValue = games[firstIndex];
                    string secondValue = games[secondIndex];
                
                    if (firstValue == secondValue) 
                    {
                        currentMachValue = firstValue;
                        successCount++;
                        Console.WriteLine($"Congrats! You have found matching elements - {currentMachValue}!");
                        games.RemoveAll(el => el == firstValue);
                    }
                    else 
                    {
                        Console.WriteLine($"Try again!");
                    }
                }
                
                else if (isValidIndex == false && games.Count > 0)
                {
                    games.Insert(games.Count / 2, $"-{count}a");
                    games.Insert(games.Count / 2, $"-{count}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                
                isValidIndex = false;
                
                command = Console.ReadLine();
            }
            
            if (games.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", games));
            }
            else
            {
                Console.WriteLine($"You have won in {successCount} turns!");
            }
            
        }
    }
}
