using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class LargestNumber
    {
        public static void largestNumber()          //Creating method
        {
            //Taking user input
            Console.WriteLine("Please enter input");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter input");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter input");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)         //If statement for checking condition
                Console.WriteLine("The number {0} is largest of all", a);
            else if (b > c)
                Console.WriteLine("The number {0} is largest of all", b);
            else
                Console.WriteLine("The number {0} is largest of all", c);
        }
    }
}
