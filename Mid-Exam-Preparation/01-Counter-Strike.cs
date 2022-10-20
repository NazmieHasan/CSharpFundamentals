using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int wonBattles = 0;
            
            while (command != "End of battle") 
            {
                int distance = int.Parse(command);
                
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                
                    return;
                }
                
                energy -= distance;
                wonBattles++;
               
                if (wonBattles % 3 == 0)
                {
                    energy += wonBattles;
                }
                
                command = Console.ReadLine();
                
                
            }
            
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
