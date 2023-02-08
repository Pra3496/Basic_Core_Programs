using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class QuoitRem
    {
        public static void findingQuotientNumber()          //Creating method
        {
            Console.WriteLine("Please enter value for Dividend");       //Taking user input for dividand
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value for Divisor");        //Taking user input for divisor
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = Math.DivRem(dividend, divisor, out int remainder);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
