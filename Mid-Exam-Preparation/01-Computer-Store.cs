using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double sum = 0;
            double totalSum = 0;
    
            while ((command != "regular") && (command != "special"))
            {
                double price = double.Parse(command);
                
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                sum += price;
                }
                
                command = Console.ReadLine();
            }
            
            double taxes = sum * 0.2;
            totalSum = sum + taxes;
            double discount = totalSum * 0.1;
            
            if (command == "special")
            {
                totalSum = totalSum - discount;
            }
            
            
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
            } 
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }

        }
    }
}
