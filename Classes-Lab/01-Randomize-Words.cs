using System;
using System.Linq;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        string[] input = Console.ReadLine()
            .Split();
            
        Random random = new Random();
            
        for (int i = 0; i < input.Length; i++)  
        {
            int randomIndex = random.Next(0, input.Length);
            string currentWord = input[i];
            string nextWord = input[randomIndex];
            
            input[i] = nextWord;
            input[randomIndex] = currentWord;
        }
        
        Console.WriteLine(string.Join(Environment.NewLine, input));
    }
}
