using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class FlipCoin
    {
        private int tail_count1;

        private int head_count1;

        private double tail_percentage1;

        private double head_percentage1;
        
        public int getTailCnt()
        {
            return this.tail_count1;
        }

        public int getHeadCnt()
        {
            return this.head_count1;
        }

        public double getTailPer()
        {
            return this.tail_percentage1;
        }

        public double getHeadPer()
        {
            return this.head_percentage1;
        }
        public void getFlipCoin()      //Method created
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
            tail_count1 = tail_count;
            head_count1 = head_count;


            
            double tail_percentage = (tail_count * 100) / iNo;      //Percentage calculating 
            double head_percentage = (head_count * 100) / iNo;      //percentage calculating

            this.tail_percentage1 = tail_percentage;
            this.head_percentage1 = head_percentage;
        }
    }
}
