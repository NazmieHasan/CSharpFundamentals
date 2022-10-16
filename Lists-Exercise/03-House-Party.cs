using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    
                string name = cmdArgs[0];
                
                if (cmdArgs.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    
                    guestList.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    
                    guestList.Remove(name);
                }
            }
            
            PrintGuestList(guestList);
        }
        
        static void PrintGuestList(List<string> guestList)
        {
            foreach (string name in guestList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
