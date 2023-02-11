using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class PowerOfTwo
    {
        public static void getPowerOfTwoNum()      //Creating method
        {
            Console.WriteLine("Please enter the range for power calculation");          //Taking user input 
            int iNo = Convert.ToInt32(Console.ReadLine());
            int result = 1;      //Initializing value

            for (int i = 1; i <= iNo; i++)        //For loop to check condition
            {
                //result = result*2;
                result = (int)Math.Pow(2, i);
                Console.WriteLine("2^{0} = {1}", i,result);
            }

        }
    }
}
