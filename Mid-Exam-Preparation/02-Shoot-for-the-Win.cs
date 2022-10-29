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
            bool isValidIndex = false;
            int count = 0;
            
            while (command != "End")
            {
                int inputIndex = int.Parse(command);
                
                if (inputIndex >= 0 && inputIndex < numbers.Length)
                {
                    isValidIndex = true;
                }
                 
                if (isValidIndex)
                {
                    count++;
                    
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currentValue = numbers[inputIndex];
                        
                        if ((i != inputIndex) && (numbers[i] != -1))
                        {
                            if (numbers[i] > currentValue)
                            {
                                numbers[i] -= currentValue;
                            }
                            else 
                            {
                                numbers[i] += currentValue;
                            }
                        }
                    }
                    
                    numbers[inputIndex] = -1;
                }
                
                isValidIndex = false;
                
                command = Console.ReadLine();
            }
            
            string resNumbers = string.Join(" ", numbers);
            
            Console.WriteLine($"Shot targets: {count} -> {resNumbers}");
        }
    }
}
