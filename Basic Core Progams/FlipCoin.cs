using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class FlipCoin
    {
        public static void getFlipCoin()      //Method created
        {
            int tail_count = 0, head_count = 0;       //Initialise values
            Console.Write("Number of times to the flipcoin : ");       //Getting  number of count head and tail
            int iNo = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();       //Random object is created

            for (int i = 1; i <= iNo; i++)        //For loop for given condition
            {
                double input = random.NextDouble();     //Using random function
                if (input < 0.5)        //Providing some condition statements
                {
                    tail_count++;
                }
                else
                {
                    head_count++;
                }
            }
            Console.WriteLine("TailCount:{0} and HeadCount:{1}",tail_count,head_count);
            double tail_percentage = (tail_count * 100) / iNo;      //Percentage calculating 
            double head_percentage = (head_count * 100) / iNo;      //percentage calculating
            Console.WriteLine("Tail={0}% and Head={1}%", tail_percentage, head_percentage);
        }
    }
}
