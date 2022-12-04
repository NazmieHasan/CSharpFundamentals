using System;
using System.Linq;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray(); 
                
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string[] commandInfo = command.Split();
                string commandName = commandInfo[0];
                
                if (commandName == "swap")
                {
                    int indexFirst = int.Parse(commandInfo[1]);
                    int indexSecond = int.Parse(commandInfo[2]);
                    int temp = numbers[indexFirst];
                    numbers[indexFirst] = numbers[indexSecond];
                    numbers[indexSecond] = temp;
                }
                else if (commandName == "multiply")
                {
                    int indexFirst = int.Parse(commandInfo[1]);
                    int indexSecond = int.Parse(commandInfo[2]);
                    numbers[indexFirst] = numbers[indexFirst] * numbers[indexSecond];
                }
                else if (commandName == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }
                }
                
                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
