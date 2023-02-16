
namespace Basic_Core_Progams
{
     
        internal class Program
        {

            static void Main(string[] args)
            {

            Console.SetWindowSize(210, 50);

            char cnt = '\0';
                string[] opt = { "FlipCoin", "LeapYear", "PowerOfTwo", "Harmonics", "Factors", "QuotientAn", "SwapTwoNumbers", "EvenOddNumber", "VowelConsonant", "LargestNumber" };
                MainPanal panal = new MainPanal();
                while (true)
                    {
                        panal.setBgFontColor("black","white");
                    Menu:
                        Console.Clear();

                        
                        panal.setMainMenu("Basic Core Program");
                        panal.setOptMenu(opt);
                        panal.setBgFontColor("yellow", "black");
                        Console.CursorLeft = 67;

                        Console.Write("Enter the Option : ");

                        panal.setBgFontColor("default","default");

                        int option = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine();

                switch (option)
                {

                            case 1:
                                panal.setSubMenuEty("FlipCoin", "====");
                                Console.CursorLeft = 67;
                                FlipCoin flip = new FlipCoin();
                                flip.getFlipCoin();
                                Console.WriteLine();
                                Console.CursorLeft = 67;
                                Console.Write("TailCount:{0} and HeadCount:{1}", flip.getTailCnt(), flip.getTailCnt());
                                Console.WriteLine();
                                Console.CursorLeft = 67;
                                Console.Write("TailCountPercentage:{0} and HeadCountPercentage:{1}", flip.getHeadPer(), flip.getHeadPer());
                                panal.printSubGrid();
                                break;
                            case 2:
                                panal.setSubMenuEty("LeapYear", "====");

                                LeapYear leap = new LeapYear();
                                Console.CursorLeft = 67;
                                Console.Write("Please enter year :");                          
                                int iYr = Convert.ToInt32(Console.ReadLine());
                                Console.CursorLeft = 67;
                                leap.chkLeapYear(iYr);
                                if (leap.flag == true) { Console.CursorLeft = 67; Console.Write("The {0} is leap year\n",iYr); }
                                else { Console.CursorLeft = 67; Console.Write("The {0} is not leap year\n", iYr); }

                                panal.printSubGrid();
                                break;
                            case 3:
                                panal.setSubMenuEty("PowerOfTwo","====");

                                PowerOfTwo pwr = new PowerOfTwo();
                                Console.CursorLeft = 67;
                                Console.Write("Please enter the range for power calculation\n");
                                int iNo = Convert.ToInt32(Console.ReadLine()); 
                                pwr.getPowerOfTwoNum(iNo);
                                Console.CursorLeft = 67;
                                Console.Write("PowerOf 2 ^ {0} = {1}",iNo,pwr);

                                panal.printSubGrid();
                                break;
                            case 4:
                                panal.setSubMenuEty("Harmonics","====");
                                HarmonicNumber.getHarmonicNumber();
                                panal.printSubGrid();
                                break;
                            case 5:
                                panal.setSubMenuEty("Factors","====");
                                Console.Write("Please enter input value : ");
                                iNo = Convert.ToInt32(Console.ReadLine());
                                Factor fact = new Factor();
                                fact.getFactors(iNo);
                                panal.printSubGrid();
                                break;
                            case 6:
                                panal.setSubMenuEty("QuoitAndReminder", "====");
                                QuoitAndReminder quoitRem = new QuoitAndReminder();
                                quoitRem.getQuotientAndReminder();
                                panal.printSubGrid();
                                break;
                            case 7:
                                panal.setSubMenuEty("SwapTwoNumbers","====");
                                SwapNumber swapnumber = new SwapNumber();
                                swapnumber.getSwapTwoNumbers();
                                panal.printSubGrid();
                                break;
                            case 8:
                                panal.setSubMenuEty("EvenOddNumber","====");
                                EvenOdd.getEvenOdd();
                                panal.printSubGrid();
                                break;
                            case 9:
                                panal.setSubMenuEty("VowelConsonant","====");
                                Vowels vowel = new Vowels();
                                vowel.getVowelConsonant();
                                panal.printSubGrid();
                                break;
                            case 10:
                                panal.setSubMenuEty("LargestNumber","====");
                                LargestNumber largenumber = new LargestNumber();
                                largenumber.getLargestNumber();
                                panal.printSubGrid();
                                break;
                            default:
                                Console.WriteLine("Please enter right option !!!!!!!!!!!!!");
                                goto Menu;
                        }
               ExitMenu:
                        
                        panal.setBgColor("black");
                        panal.setFontColor("red");

                        Console.WriteLine();
                        Console.CursorLeft = 67;
                        Console.Write("Enter Y to Continue OR N to Exit the Application");
                        Console.Write("(Y/N)=>\t");

                        Console.CursorLeft = 140;
                        cnt = Console.ReadLine()[0];

                        panal.setBgColor("default");
                        panal.setFontColor("default");

                        Console.CursorLeft = 67;
                        Console.WriteLine("\n");
                        if (('Y'.Equals(cnt)) || ('y'.Equals(cnt)))
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (('n'.Equals(cnt)) || ('N'.Equals(cnt)))
                        {
                            Console.Clear();
                            Console.CursorLeft = 67;
                            panal.endCredit("pranav waghmare");
                            break;
                        }
                        else
                        {
                            Console.CursorLeft = 67;
                            Console.WriteLine("Enter the Proper Option !!!!!!!!!!!!!!!!!!!!!");
                            goto ExitMenu;
                        }

                }
            }
        }
 
}