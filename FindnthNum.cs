using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class FindnthNum
    {
       public void Mains()
        {
            int[] arr = { 6, 3, 5, 7, 8, 9, 33, 22, 10, 67, 87, 88 };

            Console.WriteLine("Enter the n'th Number you want to Search : ");
            int n = int.Parse(Console.ReadLine());
            if (arr.Length <= n)
            {
                Console.WriteLine(n + " Enter Number is out of Array Index.");
                return;
            }
            Console.WriteLine("Enter the no of  (1)Small and (2)Largest : Number 1 or 2");
            int chuse = int.Parse(Console.ReadLine());

            if (chuse == 1)
            {
                int semolestNo = FindSmallNumber(arr, n);
                Console.WriteLine(n+" n'th Smolest No is :  "+semolestNo);
            }
            else if (chuse == 2)
            {
                int largestNo = FindLargestNo(arr, n);
                Console.WriteLine(n+" n'th Largest No is : "+largestNo);
            }
            else
            {
                Console.WriteLine("Chuse Inviled No");
            }


            static int FindSmallNumber(int[] arr, int n)
            {
                Array.Sort(arr);
                return arr[n - 1];
            }

            static int FindLargestNo(int[] arr, int n)
            {
                Array.Sort(arr);
                return arr[arr.Length - n];
            }
        }
    }
}
