using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class HarmonicNumber
    {
        public static void getHarmonicNumber()
        {
            Console.WriteLine("Please enter range for Harmonics");
            double range = Convert.ToInt32(Console.ReadLine());
            double value = 1;
            for (double dNo = 1; dNo <= range; dNo++)
            {
                value = value + (1 / value);
            }
            Console.WriteLine("The harmonic series of number is:" + value);
        }
    }
}
