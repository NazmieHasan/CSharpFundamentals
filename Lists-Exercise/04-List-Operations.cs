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
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                string commandType = cmdArgs[0];
                
                if (commandType == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (commandType == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    
                    if (IsindexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                    numbers.Insert(index, number);
                }
                else if (commandType == "Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);
                    
                    if (IsindexInvalid(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                    numbers.RemoveAt(removeIndex);
                }
                else if (commandType == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    
                    if (direction == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else
                    {
                        ShiftListRight(numbers, count);
                    }
                }
            }
            
            Console.WriteLine(string.Join(' ', numbers));
        }
        
        static bool IsindexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;
            
        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        
        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
