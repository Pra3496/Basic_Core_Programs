<<<<<<< HEAD
=======
<<<<<<< HEAD
﻿namespace Basic_Core_Progams
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Vowels vowel = new Vowels();
            vowel.getVowelConsonant();

        }
    }
=======
>>>>>>> FinalApp
﻿namespace Basic_Core_Progams
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            namespace Basic_Core_Progams
    {
        internal class Program
        {

            static void Main(string[] args)
            {
                char cnt = '\0';


                while (true)
                {
                Menu:
                    Console.WriteLine("\n***********************************************************************");
                    Console.WriteLine("***********|  WEL-COME TO BASIC CORE PROGRAMS Application  |***********");
                    Console.WriteLine("***********************************************************************");
                    Console.WriteLine("*********************  OPTIONS ARE FOLLOWING  *************************\n");
                    Console.WriteLine("1:FlipCoin\n2:LeapYear\n3:PowerOfTwo\n4:Harmonics\n5:Factors\n6:QuotientAndRemainder\n7:SwapTwoNumbers\n8:EvenOddNumber\n9:VowelConsonant\n10:LargestNumber\n11:Prime Factorization");
                    Console.WriteLine("\n*************************|  END OF OPTIONS  |*************************");
                    Console.Write("Enter the Option : ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Clear();

                    switch (option)
                    {

                        case 1:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            FlipCoin.getFlipCoin();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 2:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            LeapYear.getLeapYear();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 3:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            PowerOfTwo.getPowerOfTwoNum();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 4:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            HarmonicNumber.getHarmonicNumber();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 5:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Console.Write("Please enter input value : ");
                            int iNo = Convert.ToInt32(Console.ReadLine());
                            Factor fact = new Factor();
                            fact.getFactors(iNo);
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 6:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            QuoitAndReminder quoitRem = new QuoitAndReminder();
                            quoitRem.getQuotientAndReminder();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 7:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            SwapNumber swapnumber = new SwapNumber();
                            swapnumber.getSwapTwoNumbers();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 8:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            EvenOdd.getEvenOdd();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 9:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            Vowels vowel = new Vowels();
                            vowel.getVowelConsonant();
                            Console.WriteLine("\n****************> End of Result <******************\n");
                            break;
                        case 10:
                            Console.WriteLine("\n*******************> Result <*********************\n");
                            LargestNumber largenumber = new LargestNumber();
                            largenumber.getLargestNumber();
                            Console.WriteLine("\n****************> End of Result <******************\n");
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

}
    }
<<<<<<< HEAD
=======
>>>>>>> main
>>>>>>> FinalApp
}