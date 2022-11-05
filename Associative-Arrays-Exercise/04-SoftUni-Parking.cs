using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> register = new Dictionary<string, string>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');
                string cmdType = cmdArgs[0];
                string username = cmdArgs[1];
               
                if (cmdType == "register")
                {
                    string licensePlateNumber = cmdArgs[2];

                    if (!register.ContainsKey(username))
                    {
                        register[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        string registeredPlateNumber = register[username];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlateNumber}");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            
            foreach (var reg in register )
            {
                Console.WriteLine($"{reg.Key} => {reg.Value}");
            }
        }
    }
}
