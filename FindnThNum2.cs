using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class FindnThNum2
    {
        public void Findnth()
        {
            int[] arr = { 4, 11, 2, 33, 5, 6, 55, 7, 1, 8, 9, 100, 11, 12, 13, 15, 16 };
            Array.Sort(arr);
            Console.Write("Smolest Number is " + arr.First());
            Console.WriteLine();

            Array.Sort(arr);
            Console.Write($" Largest Number is :  {arr.Last()}");

        }
       
    }
}
