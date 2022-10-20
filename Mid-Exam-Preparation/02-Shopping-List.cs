using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            List<string> groceries = Console.ReadLine() 
                .Split("!")
                .ToList();
            
            string command = Console.ReadLine();
            
            while (command != "Go Shopping!")
            {
                string[] cmdArgs = command.Split(" ");
                string commandName = cmdArgs[0]; 
                string article = cmdArgs[1];
                
                for (int i = 0; i < groceries.Count; i++)
                {
                    if (commandName == "Urgent")
                    {
                        if (!groceries.Contains(article))
                        {
                            groceries.Insert(0, article);
                        }
                    }
                   else if (commandName == "Unnecessary")
                    {
                        if (groceries.Contains(article))
                        {
                            groceries.Remove(article);
                        }
                    }
                    else if (commandName == "Correct")
                    {
                        string newGrocerie = cmdArgs[2];
                        int index = groceries.IndexOf(article);
                        
                        if (groceries.Contains(article))
                        {
                            groceries.Insert(index, newGrocerie);
                            groceries.Remove(article);
                        }
                    }
                    else if (commandName == "Rearrange")
                    {
                        if (groceries.Contains(article))
                        {
                            groceries.Remove(article);
                            groceries.Add(article);
                        }
                    }
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine(String.Join(", ", groceries));
        }
    }
}
