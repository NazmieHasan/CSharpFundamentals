using System;
using System.Linq;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine() 
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
                
            int rotationsCount = int.Parse(Console.ReadLine());
            int tomesToRotate = rotationsCount % arr.Length;
            
            for (int r = 1; r <= tomesToRotate; r++)
            {
                int firstEl = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstEl;
            }
            
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
