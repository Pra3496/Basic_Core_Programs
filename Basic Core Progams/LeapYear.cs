using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class LeapYear
    {
        public bool flag;
        public void chkLeapYear(int iYr)                     //Created method
        {
            if (((iYr % 4 == 0) && (iYr % 100 != 0)) || (iYr % 400 == 0))         //Giving conditions to check
            { this.flag = true;  }
            else
            { this.flag = false; }
        }
    }
}
