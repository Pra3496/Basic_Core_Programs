using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Diagnostics.Contracts;
using Microsoft.VisualBasic.FileIO;
using System.Data;

namespace Basic_Core_Progams
{
    internal class MainPanal
    {
        string name1 = "",gtype1="";
        int iCnt,sset = 65;


       
        //////////////////////////// Main Menu Settings /////////////////////////////////////////
        
        public void setMainMenu(string name)
        {
            Console.WriteLine("\n");
            string nam = "WEL-COME TO "+name+" Application";

            this.gtype1 = "*";
            this.name1 = nam;

            Console.CursorLeft = sset;
            printGrid();
            Console.WriteLine();
            Console.CursorLeft = sset;
            printGrid(nam);
            Console.WriteLine();
            Console.CursorLeft = sset;
            printGrid();
            Console.WriteLine();
            Console.CursorLeft = sset;

        }

        private void printGrid(string nam)
        {
            int i;

            Console.CursorLeft = sset;
            for (i = 0; i < nam.Length; i++)
            {
                
                if (i == (nam.Length / 2))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("|{0}|", nam);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(this.gtype1);

            }


        }

        private void printGrid()
        {
            Console.CursorLeft = sset;
            for (int i = 0; i < this.name1.Length + 1; i++)
            {
                
                Console.Write(this.gtype1 + "" + this.gtype1);
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Option in Main Menu Settings


        public void setOptMenu(string[] options)
        {
            string name = "OPTION ARE FOLLOWING";

            int i;
            this.gtype1 = "===";
            Console.CursorLeft = 67;
            for (i = 0; i < name.Length; i++)
            {
                if (i == (name.Length / 2))
                {

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("|{0}|", name);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(this.gtype1);

            }
            this.iCnt = i + 2;
            Console.CursorLeft = 67;
            Console.WriteLine();
            Console.CursorLeft = 67;

            
            Console.CursorLeft = 67;
            for (int k = 0;k < options.Length;k++)
            {
                Console.CursorLeft = 67;
                Console.WriteLine("{0}: {1}", k+1, options[k]);
                Console.CursorLeft = 67;
            }
            Console.CursorLeft = 67;
            Console.WriteLine(this.iCnt);
            Console.CursorLeft = 67;
            for (int j = 0; j < this.iCnt; j++)
            {
                if (j == (this.iCnt/ 2))
                {
                    
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("|END OF OPTIONS|");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                Console.Write(this.gtype1);

            }

            Console.WriteLine();
            Console.CursorLeft = sset;


        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //Sub Menu Settings
        public void setSubMenuEty(string name,string gType)
        {
            this.name1 = name;
            this.gtype1 = gType;

            int i;
            Console.CursorLeft = 67;
            for (i = 0; i < name.Length; i++)
            {
               
                if (i == (name.Length / 2))
                {
                    
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("|{0}|", name);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                Console.Write(this.gtype1);

            }
            Console.CursorLeft = 67;
            Console.WriteLine();

            this.iCnt = (i * gType.Length)+i;
            string sortGrid = gType[0] + "";
            this.gtype1 = sortGrid;
        }

        public void printSubGrid()
        {
            Console.WriteLine("\n",this.iCnt);
            Console.CursorLeft = 67;
            for (int i = 0; i < this.iCnt-3; i++)
            {
                if (i == ((this.iCnt-3) / 2))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("|END|");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(this.gtype1);

            }
            Console.WriteLine();
            Console.CursorLeft = 67;
        }
        //  // /////////////////////////////////////////////////////////////////////////////////////////////////////////

        //styling settings /////////////////////////////////////////////////////////////////////////////////////////////
        public void setBgColor(string bgrnd)
        {
            switch (bgrnd)
            {
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }

        }

        public void setFontColor(string fnt)
        {
            
            switch (fnt)
            {
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

        }
        public void setBgFontColor(string bgrnd,string fnt)
        {
            switch (bgrnd)
            {
                case "white":
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
            switch (fnt)
            {
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

        }

        



        //////////   End Credits for application ///////////
        public void endCredit(string name)
        {
            Console.Write("\n\n\n");
            Console.CursorLeft = sset;
            Console.WriteLine("**************>| THANK YOU for using this application |<***************");
            Console.CursorLeft = sset;
            Console.WriteLine("\t\t     -----------------------------");
            Console.CursorLeft = sset;
            Console.WriteLine("\t\t\tDesigned and Developed by \t\t\t");
            Console.CursorLeft = sset;
            Console.WriteLine("\t\t\t     " + name.ToUpper());
            Console.CursorLeft = sset;
            Console.WriteLine("\t\t        -----------*-----------");

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
