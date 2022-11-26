using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
                
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            while(command != "end")
            {
                string[] cmdArgs = command.Split(' ');  
                string commandType = cmdArgs[0];
                
                if (commandType == "Add")
                {
                    int passengerCount = int.Parse(cmdArgs[1]);
                    wagons.Add(passengerCount);
                }
                else
                {
                    int passengerCount = int.Parse(cmdArgs[0]);
                    
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengerCount <= n)
                        {
                            wagons[i] += passengerCount;
                            break;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
