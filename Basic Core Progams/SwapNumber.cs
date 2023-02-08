using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class SwapNumber
    {
        public static void SwapTwoNumbers1()        //Creating method
        {
            int a = 5;          //Initializing input value
            int b = 10;
            int temp = a;
            Console.WriteLine("Numbers before swaping is {0} and {1}", a, b);
            a = b;
            b = temp;
            //Another method to solve
            //a = a + b;
            // b = a - b;
            //a = a - b;
            Console.WriteLine("Numbers after swaping is {0} and {1}", a, b);
        }
    }
}
