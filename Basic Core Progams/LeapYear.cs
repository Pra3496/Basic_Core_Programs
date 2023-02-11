using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class LeapYear
    {
        public static void getLeapYear()                     //Created method
        {
            Console.Write("Please enter year :");                          //Getting user input
            int iYr = Convert.ToInt32(Console.ReadLine());

            if (((iYr % 4 == 0) && (iYr % 100 != 0)) || (iYr % 400 == 0))         //Giving conditions to check
            { Console.WriteLine("The {0} is leap year", iYr); }
            else
            { Console.WriteLine("The {0} is not leap year",iYr);}
        }
    }
}
