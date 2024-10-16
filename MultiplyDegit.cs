using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class MultiplyDegit
    {
        public int DegitMultiply()
        {
            Console.Write("Enter an integer greater than 10: ");
            int number = int.Parse(Console.ReadLine());

            while (number >= 10)
            {
                number = MultiplyDigits(number);
            }

            Console.WriteLine("Final single-digit result: " + number);

            Console.ReadLine();

            return number;
        }

        static int MultiplyDigits(int num)
        {
            int product = 1;
            while (num > 0)
            {
                int digit = num % 10; // Extract the last digit
                product *= digit; // Multiply the digit to the product
                num /= 10; // Remove the last digit
            }
            return product;
        }
    }

}
