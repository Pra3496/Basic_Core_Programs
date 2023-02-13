using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Basic_Core_Progams
{
    internal class MainPanal
    {
        string name1 = "",gtype1="";
        int iCnt;


       
        //////////////////////////// Main Menu Settings /////////////////////////////////////////
        
        public void setMainMenu(string name)
        {
            Console.WriteLine("\n");
            string nam = "WEL-COME TO "+name+" Application";

            this.gtype1 = "*";
            this.name1 = nam;

            printGrid();
            Console.WriteLine();
            printGrid(nam);
            Console.WriteLine();
            printGrid();
            Console.WriteLine();

        }

        private void printGrid(string nam)
        {
            int i;

            for (i = 0; i < nam.Length; i++)
            {
                if (i == (nam.Length / 2))
                {
                    Console.Write("|{0}|", nam);
                }

                Console.Write(this.gtype1);

            }


        }

        private void printGrid()
        {

            for (int i = 0; i < this.name1.Length + 1; i++)
            {

                Console.Write(this.gtype1 + "" + this.gtype1);
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Option in Main Menu Settings


        public void setOptMenu(string[] options)
        {
            string name = "OPTIONS ARE FOLLOWING";

            int i;
            for (i = 0; i < name.Length; i++)
            {
                if (i == (name.Length / 2))
                {
                    Console.Write("|{0}|", name);
                }

                Console.Write(this.gtype1 + "" + this.gtype1+"" + this.gtype1);

            }
            Console.WriteLine();
            this.iCnt = i;

            for(int k = 0;k < options.Length;k++)
            {
                Console.WriteLine("{0}: {1}", k+1, options[k]);
            }

            Console.WriteLine();
            for (int j = 0; j < this.iCnt + 2; j++)
            {
                if (j == (this.iCnt / 2))
                {
                    Console.Write("|END OF OPTIONS|");
                }

                Console.Write(this.gtype1 + "" + this.gtype1 + "" + this.gtype1);

            }
            Console.WriteLine();

            
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //Sub Menu Settings
        public void setSubMenuEty(string name,string gType)
        {
            this.name1 = name;
            this.gtype1 = gType;

            int i;
            for (i = 0; i < name.Length; i++)
            {
                if (i == (name.Length / 2))
                {
                    Console.Write("|{0}|", name);
                }

                Console.Write(this.gtype1);

            }
            Console.WriteLine((i*gType.Length) + i + 2);

            this.iCnt = (i * gType.Length) +i + 2;
            string g = gType[0] + "";
            this.gtype1 = g;
        }

        public void printSubGrid()
        {
            Console.WriteLine(this.iCnt);
            for (int i = 0; i < this.iCnt-5; i++)
            {
                if (i == ((this.iCnt-5) / 2))
                {
                    Console.Write("|END|");
                }

                Console.Write(this.gtype1);

            }
            Console.WriteLine();

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
