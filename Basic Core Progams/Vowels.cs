using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Progams
{
    internal class Vowels
    {
        public static void vowelConsonant()         //Creating method
        {
            Console.WriteLine("Plaese provide input string");       //Taking user input
            string input = Console.ReadLine();
            for (int i = 0; i <= input.Length-1; i++)       //For loop for condition 
            {
                if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                        Console.WriteLine($"{input[i]} is vowel");
                    else
                        Console.WriteLine($"{input[i]} is consonant");
                }
            }
        }
    }
}
