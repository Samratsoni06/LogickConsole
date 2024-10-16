using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class BinarySearch
    {
        public void BinarySearchMetMain()
        {
            Console.Write("Enter Search Value :");
            int item = int.Parse(Console.ReadLine());

            int[] arr = { 3, 4, 5, 7, 8, 23, 44, 55, 66, 99, 101, 123 };
            int result = BinarySearchMet(arr, item);

            if (result < 0)
            {
                Console.WriteLine($"{item} in Not Found");
            }
            else
            {
                Console.WriteLine($"{item} is Found index of {result}");
            }
        }

        public int BinarySearchMet(int[]arr,int item)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if(item == arr[mid])
                {
                    return mid;
                }
                else if(item < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
   
}
