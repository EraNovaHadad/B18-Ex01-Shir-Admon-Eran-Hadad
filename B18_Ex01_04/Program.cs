////-----------------------------------------------------------------------
////    Eran Hadad 204285209
////    Shir Admon 205641277
////    String analysis - Drill -4-
////-----------------------------------------------------------------------

// $G$ CSS-999 (-1) Use ! operator instead of == false.
// $G$ CSS-013 (-10) Bad variable name (should be in the form of i_PascalCase).


namespace B18_Ex01_04
{
    using System;
    using System.Text;

    public class Program
    {
        public static class Details
        {
            public const int sizeOfString = 8;
        }

        public static void Main()
        {
            stringAnalysis();
        }

        private static void stringAnalysis()
        {
            Console.WriteLine("Enter string with {0} chars:", Details.sizeOfString);
            string str = Console.ReadLine();
            while (checkValidtionOfStr(str) == false)
            {
                Console.WriteLine("Invalid input ! , please try again:");
                str = Console.ReadLine();
            }

            Console.WriteLine("==============================");
            if (isPalindrom(str))
            {
                Console.WriteLine(str + " is palindrom.");
            }
            else
            {
                Console.WriteLine(str + " is not palindrom.");
            }

            if (!char.IsLetter(str, 0))
            {
                if (isEvenOrOdd(str))
                {
                    Console.WriteLine(str + " is even.");
                }
                else
                {
                    Console.WriteLine(str + " is odd.");
                }
            }
            else
            {
                Console.WriteLine("You entered string of letters and number of lower letters are {0}.", countLowerLetters(str));
            }
        }

        private static bool checkValidtionOfStr(string i_str)
        {
            bool checkValidInput = false;
            if (i_str.Length == Details.sizeOfString)
            {
                ////check if the first input is digit
                if (char.IsDigit(i_str, 0))
                {
                    for (int i = 1; i < Details.sizeOfString; i++)
                    {
                        if (char.IsDigit(i_str[i]) == false)
                        {
                            return false;
                        }
                    }

                    checkValidInput = true;
                }
                else
                    if (char.IsLetter(i_str, 0))
                {
                    for (int i = 1; i < Details.sizeOfString; i++)
                    {
                        if (char.IsLetter(i_str[i]) == false)
                        {
                            return false;
                        }
                    }

                    checkValidInput = true;
                }
            }
            else
            {
                return false;
            }

            return checkValidInput;
        }

        private static bool isPalindrom(string i_str)
        {
            bool checkPalindrom = true;

            for (int i = 0, j = Details.sizeOfString - 1; i < Details.sizeOfString / 2 && j > Details.sizeOfString / 2; i++, j--)
            {
                if (i_str[i] != i_str[j])
                {
                    checkPalindrom = false;
                }
            }

            return checkPalindrom;
        }

        private static bool isEvenOrOdd(string i_str)
        {
            bool flag = true;
            if (char.IsLetter(i_str, 0))
            {
                return false;
            }

            if (char.IsDigit(i_str, 0))
            {
                if ((i_str[Details.sizeOfString - 1] - '0') % 2 != 0)
                {
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        private static int countLowerLetters(string i_str)
        {
            int countLowerLetter = 0;
            for (int i = 0; i < Details.sizeOfString; i++)
            {
                if (char.IsLower(i_str, i))
                {
                    countLowerLetter++;
                }
            }

            return countLowerLetter;
        }
    }
}
