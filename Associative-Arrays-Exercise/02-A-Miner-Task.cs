using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            
            string resource;
            
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                
                resources[resource] += quantity;
            }
            
            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
            
        }
    }
}
