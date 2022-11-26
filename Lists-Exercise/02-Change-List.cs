using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
                
            string command = Console.ReadLine();
            
            while(command != "end")
            {
                string[] cmdArgs = command.Split();  
                string commandType = cmdArgs[0];
                int element = int.Parse(cmdArgs[1]);
                
                if (commandType == "Delete")
                {
                    numbers.RemoveAll(el => el == element);
                }
                else if (commandType == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, element);
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
