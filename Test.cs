using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class Test
    {
        public void Higest()
        {
            string str = "gfdgsdyfghhhhhhhhhhhhhhhhgfgfgfgggggggg";

            var cha = str.Distinct().ToDictionary(x => x, x => str.Count(c => c == x));

            var res = cha.OrderByDescending(x => x.Value).First().Key;

            Console.WriteLine(res);
        }

        public void SortArray()
        {
            int[] arr = { 1, 5, 6, 73, 4, 9, 2, 5, 6, 7 };

            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }



        //ExMethod objProgram = new ExMethod();
        //Console.WriteLine("Add with two int parameter :" + objProgram.Add(3, 2));
        //Console.WriteLine("Add with three int parameter :" + objProgram.Add(3, 2, 8));
        //Console.WriteLine("Add with two float parameter :" + objProgram.Add(3.7f, 2.2f));
        //Console.WriteLine("Add with two string parameter :" + objProgram.Add("hello", "world"));

        //Childcls childcls  = new Childcls();
        //childcls.Display(3,4);


    //



}
}
