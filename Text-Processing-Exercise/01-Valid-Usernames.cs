using System;
using System.Linq;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");
 
            foreach (string currentName in usernames) 
            {
                if (currentName.Length > 3 && currentName.Length <= 16)
                {
                    bool isUsernameValid = true;
                    
                    foreach (char currentChar in currentName)
                    {
                        if (!(char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    
                    if (isUsernameValid)
                    {
                        Console.WriteLine(currentName);
                    }
                }
            }
        }
    }
}
