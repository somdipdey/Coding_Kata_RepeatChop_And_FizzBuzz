using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Kata_RepeatChop_And_FizzBuzz
{
    public class FizzBuzzCalculator
    {
        // Method to check divisible by 3
        private static bool DivisibleByThree(int Num)
        {
            if (Num % 3 == 0)
                return true;

            return false;
        }

        // Method to check dividisble by 5
        private static bool DivisibleByFive(int Num)
        {
            if (Num % 5 == 0)
                return true;

            return false;
        }

        // Find the other factor than the divisor of the number
        private static int OtherFactor(int Paramter, int Divisor)
        {
            return Paramter / Divisor;
        }

        // Replace Z based on the MutipleOfZ variable
        private static string ReplaceZs(string InputString, int MutipleOfZ)
        {
            string zs = new String('z', MutipleOfZ);
            
            InputString = InputString.Replace("zz", zs);

            return InputString;
        }

        private static Tuple<bool, bool, int, int> CalculateMutipleOfThreeOrFive(int Num)
        {
            // Use tuple to return whether the number is divisible by 3 or 5 or both or none.
            // If the number is divisible by 3
            if(DivisibleByThree(Num) && !DivisibleByFive(Num))
            {
                int otherFactor = OtherFactor(Num, 3);
                return Tuple.Create(true, false, otherFactor, 0);
            }
            // If the number is divisible by 5
            else if(!DivisibleByThree(Num) && DivisibleByFive(Num))
            {
                int otherFactor = OtherFactor(Num, 5);
                return Tuple.Create(false, true, 0, otherFactor);
            }
            // If the number is divisible by both 3 and 5
            else if(DivisibleByThree(Num) && DivisibleByFive(Num))
            {
                int otherFactorOfThree = OtherFactor(Num, 3);
                int otherFactorOfFive = OtherFactor(Num, 5);
                return Tuple.Create(true, true, otherFactorOfThree, otherFactorOfFive);
            }

            // Return default if the number is divisible by neither 3 or 5
            return Tuple.Create(false, false, 0, 0);
        }


        // Summary:
        // FizzBuzz method to check whether a number (iterable) disible by 3 or 5 or both and 
        // print out Fizz Buzz depending on the factors of the number. Using List<string> instead of string[] because 
        // allocating list of string on the memory won't lead to "OutOfMemoryException". On top, in the App.config 
        // the gcAllowVeryLargeObjects is set to true, which means that if the size of List object grows bigger can 2 GB then
        // the program will still execute without any issue (till RAM is still available). The max number of string objects 
        // a list can hold is 2^31.
        public static List<string> FizzBuzz(int Parameter)
        {
            List<string> listOfFizBuzz = new List<string>();
            listOfFizBuzz.Add("0");// Print zero by default

            // Time complexity is O(N) for fizz buzz.
            for (int num = 1; num <= Parameter; num++)
            {
                var factorTuple = CalculateMutipleOfThreeOrFive(num);

                // factorTuple.Item1 == true or false for factor of 3
                // factorTuple.Item2 == true or false for factor of 5
                // factorTuple.Item3 == factor of 3
                // factorTuple.Item4 == factor of 5

                // For factor of 3
                if (factorTuple.Item1 && !factorTuple.Item2)
                {
                    listOfFizBuzz.Add(ReplaceZs("Fizz", factorTuple.Item3));
                }
                // For factor of 5
                else if(!factorTuple.Item1 && factorTuple.Item2)
                {
                    listOfFizBuzz.Add(ReplaceZs("Buzz", factorTuple.Item4));
                }
                // For factor of both 3 && 5
                else if(factorTuple.Item1 && factorTuple.Item2)
                {
                    listOfFizBuzz.Add(ReplaceZs("Fizz", factorTuple.Item3) + "-" + ReplaceZs("Buzz", factorTuple.Item4));
                }
                // Default: Just print the number
                else
                {
                    listOfFizBuzz.Add(num.ToString());
                }
            }

            return listOfFizBuzz;
        }


    }
}
