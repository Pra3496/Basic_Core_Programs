using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class SwapNumber
    {
        public void getSwapTwoNumbers()        //Creating method
        {
            int iNo = 5;          //Initializing input value
            int iNo2 = 10;
            int temp = iNo;
            Console.WriteLine("Numbers before swaping is {0} iNond {1}", iNo, iNo2);
            iNo = iNo + iNo2;
            iNo2 = iNo - iNo2;
            iNo = iNo - iNo2;
            Console.WriteLine("Numbers after swaping is {0} and {1}", iNo, iNo2);
        }
    }
}
