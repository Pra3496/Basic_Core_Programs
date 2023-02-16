using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class PowerOfTwo
    {
        public int result;
        public void getPowerOfTwoNum(int iNo)      //Creating method
        {
            
            for (int i = 1; i <= iNo; i++)        //For loop to check condition
            {
                //result = result*2;
                this.result = (int)Math.Pow(2, i);
                
            }

        }
    }
}
