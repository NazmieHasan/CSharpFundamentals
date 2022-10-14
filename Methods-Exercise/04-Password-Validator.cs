using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            string inputPassword = Console.ReadLine();
            
            bool isLengthValid = IsPasswordLengthValid(inputPassword);
            bool isPassAlphanumeric = IsPasswordAlphaNumeric(inputPassword);
            bool hasTwoDigit = IsPasswordContainsAtLeastTwoDigit(inputPassword);
            
            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!isPassAlphanumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            
            if (!hasTwoDigit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            
            if (isLengthValid && isPassAlphanumeric && hasTwoDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }
        
        static bool IsPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        
        static bool IsPasswordAlphaNumeric(string password)
        {
           foreach (char ch in password)
           {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
           }
           
           return true;
        }
        
        static bool IsPasswordContainsAtLeastTwoDigit(string password)
        {
            int digitCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            
            return digitCount >= 2;
        }
        
    }
}
