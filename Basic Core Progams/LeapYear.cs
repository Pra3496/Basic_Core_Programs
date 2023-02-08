using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class LeapYear
    {
        public static void LeapYearPrgoram()       //Created method
        {
            Console.WriteLine("Please enter year");         //Getting user input
            int Year = Convert.ToInt32(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))         //Giving conditions to check
                Console.WriteLine("The {0} is leap year", Year);
            else
                Console.WriteLine("The {0} is not leap year", Year);
        }
    }
}
