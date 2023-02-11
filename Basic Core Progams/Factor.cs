using System;
using System.Globalization;

namespace Basic_Core_Progams
{
    internal class Factor
    {
        
        public void getFactors(int iNo)         //Creating method
        {
            for (int div = 2; div * div <= iNo; div++)
            {
                while (iNo % div == 0)
                {
                    iNo = iNo / div;
                    Console.Write(div + " ");
                }
            }
            if (iNo != 1)
            {
                Console.Write(iNo);
            }
        }
    }
}
