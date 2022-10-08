using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()) + 30;
            
            if (min > 59) 
            {
                hour += 1;
                min -= 60;
            }
            
            if (hour > 23)
            {
                hour = 0;
            }
            
            Console.WriteLine($"{hour}:{min:D2}");
        }
    }
}
