
namespace Basic_Core_Progams
{
     
        internal class Program
        {

            static void Main(string[] args)
            {
            
                char cnt = '\0';
                string[] opt = { "FlipCoin", "LeapYear", "PowerOfTwo", "Harmonics", "Factors", "QuotientAn", "SwapTwoNumbers", "EvenOddNumber", "VowelConsonant", "LargestNumber" };
                MainPanal panal = new MainPanal();
                while (true)
                    {
                    Menu:
                        Console.Clear();
                        panal.setMainMenu("Basic Core Program");
                        panal.setOptMenu(opt);
                        Console.Write("Enter the Option : ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (option)
                        {

                            case 1:
                                panal.setSubMenuEty("FlipCoin","====");
                                FlipCoin.getFlipCoin();
                                panal.printSubGrid();
                                break;
                            case 2:
                                panal.setSubMenuEty("LeapYear","====");
                                LeapYear.getLeapYear();
                                panal.printSubGrid();
                                break;
                            case 3:
                                panal.setSubMenuEty("PowerOfTwo","====");
                                PowerOfTwo.getPowerOfTwoNum();
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
                                int iNo = Convert.ToInt32(Console.ReadLine());
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

                        Console.WriteLine("\nEnter Y to Continue OR N to Exit the Application\n");
                        Console.Write("(Y/N)=>\t");
                        cnt = Console.ReadLine()[0];
                        Console.WriteLine("\n");
                        if (('Y'.Equals(cnt)) || ('y'.Equals(cnt)))
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (('n'.Equals(cnt)) || ('N'.Equals(cnt)))
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n**************>| THANK YOU for using this application |<***************");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nEnter the Proper Option !!!!!!!!!!!!!!!!!!!!!");
                            goto ExitMenu;
                        }

                }
            }
        }
 
}