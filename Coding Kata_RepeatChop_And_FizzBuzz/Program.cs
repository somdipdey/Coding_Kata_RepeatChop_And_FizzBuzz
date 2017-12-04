using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Kata_RepeatChop_And_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //without altering any of the code in Main() write code in this fiddle that satisfies the two examples below: 

            Console.WriteLine("(1)\t====== Remove Extra Chars ======"
                              + "\n\n\t\tReturn a string where the number of consecutive characters of the same value is limited to the parameter supplied\n");

            //should return "aabbccdd"
            Console.WriteLine("aaabbcccccdddd".RemoveConsecuitiveChars(2));

            
            Console.WriteLine("\n\n(2)\t====== Fizz Buzz ======"
                              + "\n\n\t\tShould return each number between zero and its parameter but replaces multiples of 3 with 'Fizz' and multiples of 5 with 'Buzz'"
                              + "\n\n\t\tWhere the number of 'z' characters each word is the same as the other factor of the input number"
                              + "\n\n\t\tFor multiples of both 3 and 5 replace the number with both of the corresponding 'Fizz'-'Buzz' words. eg 15=\"Fizzzzz-Buzzz\"\n");

            foreach (var s in FizzBuzzCalculator.FizzBuzz(100))
            {
                Console.WriteLine(s);
            }
            
            // Readline to stop the console from shutting down after execution is complete
            Console.ReadLine();
        }
    }
}
