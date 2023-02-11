using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class LargestNumber
    {
        public void getLargestNumber()          //Creating method
        {
            //Taking user input
            Console.WriteLine("Please enter input");
            int iNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter input");
            int iNo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter input");
            int iNo3 = Convert.ToInt32(Console.ReadLine());

            if (iNo > iNo2 && iNo > iNo3)         //If statement for checking condition
            { Console.WriteLine("The number {0} is largest of all", iNo); }
            else if (iNo2 > iNo3)
            { Console.WriteLine("The number {0} is largest of all", iNo2); }
            else
            { Console.WriteLine("The number {0} is largest of all", iNo3); }
        }
    }
}
