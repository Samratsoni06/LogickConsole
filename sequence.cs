using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class sequence
    {
        public void SequenceMain()
        {
            Console.Write("Enter Max Value : ");
            int Max = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 2 * Max; i++)
            {
                if (i <= Max)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(2 * Max - i);
                }

                if (i < 2 * Max)
                {
                    Console.Write(" , ");
                }
            }
            Console.WriteLine();
        }
    }
}
