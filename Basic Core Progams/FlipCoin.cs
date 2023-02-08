using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class FlipCoin
    {
        public static void flipCoin()      //Method created
        {
            int tailCount = 0, headCount = 0;       //Initialise values
            Console.WriteLine("Number of times to the flipcoin");       //Getting  number of count head and tail
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();       //Random object is created

            for (int i = 1; i <= n; i++)        //For loop for given condition
            {
                double input = random.NextDouble();     //Using random function
                if (input < 0.5)        //Providing some condition statements
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("TailCount:{0} and HeadCount:{1}", tailCount, headCount);
            double tailPercentage = (tailCount * 100) / n;      //Percentage calculating 
            double headPercentage = (headCount * 100) / n;      //percentage calculating
            Console.WriteLine("Tail={0}% and Head={1}%", tailPercentage, headPercentage);
        }
    }
}
