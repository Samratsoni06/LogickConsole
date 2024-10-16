using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class SwapVal
    {
        public void SwapMain()
        {
            Console.Write("Entre String :");
            string input = Console.ReadLine();
            string swappedString = SwapNeighborChars(input);

            Console.WriteLine("Original string: " + input);
            Console.WriteLine("Swapped string: " + swappedString);
        }
        static string SwapNeighborChars(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i += 2)
            {
                char temp = charArray[i];
                charArray[i] = charArray[i + 1];
                charArray[i + 1] = temp;
            }

            return new string(charArray);
        }
    }
}
