////-----------------------------------------------------------------------
////    Eran Hadad 204285209
////    Shir Admon 205641277
////    Statistics number - Drill -5-
////-----------------------------------------------------------------------

// $G$ CSS-013 (-10) Bad variable name (should be in the form of i_PascalCase).

namespace B18_Ex01_05
{
    using System;
    using System.Text;

    public class Program
    {
        public static class Details
        {
            public const int sizeOfNumber = 8;
        }

        public static void Main()
        {
            statisticsNumber();
        }

        private static void statisticsNumber()
        {
            Console.WriteLine("please enter number with {0} digits:", Details.sizeOfNumber);
            string numberToCheck = Console.ReadLine();
            while (!checkValidation(numberToCheck))
            {
                Console.WriteLine("Invalid input , please try");
                numberToCheck = Console.ReadLine();
            }

            Console.WriteLine("==============================");
            Console.WriteLine("The max  digit  of your input = {0} ", maxDigitOfNum(numberToCheck));
            Console.WriteLine("The min  digit  of your input = {0} ", minDigitNum(numberToCheck));
            Console.WriteLine("The even digits of your input = {0} ", countEvenDigit(numberToCheck));
            Console.WriteLine(countDigitSmallerThanUnitytEvenDigit(numberToCheck) + " digits smaller than " + (numberToCheck[Details.sizeOfNumber - 1] - '0' + "."));
        }

        private static bool checkValidation(string i_numberToCheck)
        {
            long numberToCheck;
            long.TryParse(i_numberToCheck, out numberToCheck);
            if (numberToCheck < 0 || i_numberToCheck.Length != Details.sizeOfNumber)
            {
                return false; //// if input is in minus or not has 8 digits
            }

            foreach (char ch in i_numberToCheck)
            {
                if (!char.IsDigit(ch))
                {
                    return false; //// if char in string input is letter
                }
            } 

            return true;
        }

        private static int maxDigitOfNum(string i_numberToCheck)
        {
            int maxDigit = i_numberToCheck[0] - '0'; ////ascii of the first input
            for (int i = 1; i < Details.sizeOfNumber; i++)
            {
                maxDigit = Math.Max(maxDigit, i_numberToCheck[i] - '0');
            }

            return maxDigit;
        }

        private static int minDigitNum(string i_numberToCheck)
        {
            int minDigit = i_numberToCheck[0] - '0'; ////ascii of the first input
            for (int i = 1; i < Details.sizeOfNumber; i++)
            {
                minDigit = Math.Min(minDigit, i_numberToCheck[i] - '0');
            }

            return minDigit;
        }

        private static int countEvenDigit(string i_numberToCheck)
        {
            int countEvenDigit = 0;

            for (int i = 0; i < Details.sizeOfNumber; i++)
            {
                if ((i_numberToCheck[i] - '0') % 2 == 0)
                {
                    countEvenDigit++;
                }
            }

            return countEvenDigit;
        }

        private static int countDigitSmallerThanUnitytEvenDigit(string i_numberToCheck)
        {
            int countDigit = 0;
            int unityDigit = i_numberToCheck[Details.sizeOfNumber - 1] - '0';

            for (int i = 0; i < Details.sizeOfNumber - 1; i++)
            {
                if ((i_numberToCheck[i] - '0') < unityDigit)
                {
                    countDigit++;
                }
            }

            return countDigit;
        }
    }
}
