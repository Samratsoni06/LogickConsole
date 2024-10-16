using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickConsole
{
    public class OverridingMet
    {
        public virtual void Display(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Parent Class Method  Sum  = " + c);
        }
    }

    public class Childcls: OverridingMet
    {
        public override void Display(int a,int b)
        {
            int c = a + b;  
             Console.WriteLine("Child Class Method  Sum  = " + c );
        }
    }

}
