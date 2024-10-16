using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class CharacterCount
    {

        public void CharMain()
        {
            string input = "TAPAN KUMAR 1234";

            int CCount = 0;
            int NCount = 0;
            string capitalChars = "";
            string numericChars = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                {
                    CCount++;
                    capitalChars += ch;
                }

                if (char.IsDigit(ch))
                {
                    NCount++;
                    numericChars += ch;
                }
            }

            Console.WriteLine("Input String: " + input);
            Console.WriteLine("Capital Letters Count: " + CCount);
            Console.WriteLine("Capital Letters: " + capitalChars);
            Console.WriteLine("Numeric Characters Count: " + NCount);
            Console.WriteLine("Numeric Characters: " + numericChars);

        }
        
    }
}
