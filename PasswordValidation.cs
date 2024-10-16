using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class PasswordValidation
    {
        public void PasswordMain()
        {
            Console.Write("Enter Password:");
            string password = Console.ReadLine(); //"P@ssword123"
            bool isValid = ValidatePassword(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is Not valid.");
            }
        }

        static bool ValidatePassword(string password)
        {
            if (password.Length < 6 || password.Length > 24)
            {
                Console.WriteLine("Password must be between 6 and 24 characters.");
                return false;
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                return false;
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                Console.WriteLine("Password must contain at least one lowercase letter.");
                return false;
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                Console.WriteLine("Password must contain at least one digit.");
                return false;
            }

            if (!Regex.IsMatch(password, "[!@#$%^&*().]"))
            {
                Console.WriteLine("Password must contain at least one special character (!@#$%^&*()).");
                return false;
            }

            if (Regex.IsMatch(password, @"(.)\1{2,}"))
            {
                Console.WriteLine("Password must not contain more than two repeated consecutive characters.");
                return false;
            }

            return true;
        }
    }
}
