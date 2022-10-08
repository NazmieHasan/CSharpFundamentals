using System;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
           
            int headsetCnt = lostGames / 2;
            int mouseCnt = lostGames / 3;
            int keyboardCnt = lostGames / 6;
            int displayCnt = lostGames / 12;
            
            double expenses = (headsetCnt * headsetPrice) + (mouseCnt * mousePrice) + (keyboardCnt * keyboardPrice) + (displayCnt * displayPrice);
            
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
