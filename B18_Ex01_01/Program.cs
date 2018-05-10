////-----------------------------------------------------------------------
////    Eran Hadad 204285209
////    Shir Admon 205641277
////    Binary series - Drill -1-
////-----------------------------------------------------------------------

// $G$ RUL-003 (-20) No submission report attached to the solution.
// $G$ CSS-013 (-15) Bad variable name (should be in the form of i_PascalCase).

namespace B18_Ex01_01
{
    using System;
    using System.Text;

    public class Program
    {
        public static class Details
        {
            public const int sizeOfSeries = 3;
            public const int numOfDigit = 9;
            public const int maxSizeOfDecNum = 3;
        }

        public static void Main()
        {
            binarySeries();
        }

        private static void binarySeries()
        {
            string[] seriesOfBinary = new string[Details.sizeOfSeries]; ////Array of binary numbers(3)
            inputNumbers(seriesOfBinary);
            Console.WriteLine("==============================");
            int[] arrayOfDecmial = convertToDecimal(seriesOfBinary);
            printDecimalArray(arrayOfDecmial, seriesOfBinary);
            Console.WriteLine("Avarage of your inputs = {0:0.00}", avarageOfDigitDecimalNum(seriesOfBinary));
            Console.WriteLine("==============================");
            checkIfTheSeriesDecsending(arrayOfDecmial);
            Console.WriteLine("You entered " + isPowerOfTwo(arrayOfDecmial) + "/" + Details.sizeOfSeries + " numbers of power of 2");
            Console.WriteLine("==============================");
            Console.WriteLine("Average of zero in your inputs is {0:0.00} ", avgOfZero(seriesOfBinary)); ////{0:0.00} - Print only 2 digits after the "."
            Console.WriteLine("Average of one  in your inputs is {0:0.00} ", avgOfOne(seriesOfBinary));
        }

        private static void inputNumbers(string[] i_seriesOfBinary)
        {
            System.Console.WriteLine("Please Enter {0} binary numbers with {1} digits:", Details.sizeOfSeries, Details.numOfDigit);
            int sizeOfSeries = Details.sizeOfSeries;
            int i = 0;
            while (sizeOfSeries != 0)
            {
                string binaryNumber = System.Console.ReadLine();
                if (binaryNumber.Length == Details.numOfDigit && isBinaryNum(binaryNumber))
                {
                    i_seriesOfBinary[i] = binaryNumber.ToString();
                    i++;
                    sizeOfSeries--;
                }
                else
                {
                    Console.WriteLine("Invalid input ! , please try again");
                }
            }
        }

        private static bool isBinaryNum(string binaryNumber)
        {
            foreach (char ch in binaryNumber)
            {
                if (ch != '0' && ch != '1')
                {
                    return false;
                }
            }

            return true;
        }

        private static int[] convertToDecimal(string[] binaryNubmer)
        {
            int[] arrBinNumber = new int[Details.sizeOfSeries]; // size of array = 3

            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                int convertFromStringToInt = int.Parse(binaryNubmer[i]);
                arrBinNumber[i] = convertFromStringToInt;
            }

            double decimalNumber = 0;
            int digit = 0;
            int tempBinaryNumber = 0;
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                tempBinaryNumber = arrBinNumber[i];
                for (int j = 0; j < Details.numOfDigit; j++)
                {
                    digit = tempBinaryNumber % 10;
                    if (digit == 1)
                    {
                        decimalNumber += Math.Pow(2.0, j);
                    }

                    tempBinaryNumber /= 10;
                }

                arrBinNumber[i] = (int)decimalNumber;
                decimalNumber = 0;
                digit = 0;
            }

            return arrBinNumber;
        }

        private static void printDecimalArray(int[] arrayOfDecimal, string[] binaryNubmer)
        {
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                Console.WriteLine("Binary Nubmer = {0} ", binaryNubmer[i]);
                Console.Write("equal to Decimal Number = {0}", arrayOfDecimal[i]);
                Console.WriteLine("\n==============================");
            }
        }

        private static double avarageOfDigitDecimalNum(string[] i_seriesOfBinary)
        {
            int[] arrOfDecimal = convertToDecimal(i_seriesOfBinary);

            double sumOfDecmialNumber = 0;
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                sumOfDecmialNumber += arrOfDecimal[i];
            }

            return sumOfDecmialNumber / Details.sizeOfSeries;
        }

        private static void checkIfTheSeriesDecsending(int[] arrayOfDecimal)
        {
            int tempDecNum;
            int countDigit = 0;
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                tempDecNum = arrayOfDecimal[i];
                for (int j = 0; j < Details.maxSizeOfDecNum; j++)
                {
                    if (tempDecNum % 10 < (tempDecNum / 10) % 10)
                    {
                        tempDecNum /= 10;
                        countDigit++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (countDigit == Details.maxSizeOfDecNum - 1)
                {
                    Console.WriteLine("The number " + arrayOfDecimal[i] + " is decsending");
                    Console.WriteLine("==============================");
                }

                countDigit = 0;
            }
        }

        private static int isPowerOfTwo(int[] arrayOfDecimal)
        {
            int countOfPower = 0;
            int tempNumberFromArr;
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                tempNumberFromArr = arrayOfDecimal[i];

                while (tempNumberFromArr > 0)
                {
                    if (tempNumberFromArr % 2 != 0)
                    {
                        break;
                    }

                    tempNumberFromArr /= 2;
                }

                if (tempNumberFromArr == 1)
                {
                    countOfPower++;
                }
            }

            return countOfPower;
        }

        private static double avgOfZero(string[] i_seriesOfBinary)
        {
            double countOfZero = 0;
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                foreach (char ch in i_seriesOfBinary[i])
                {
                    if (ch == '0')
                    {
                        countOfZero++;
                    }
                }
            }

            return countOfZero / Details.sizeOfSeries;
        }

        private static double avgOfOne(string[] i_seriesOfBinary)
        {
            double countOfOne = 0;
            for (int i = 0; i < Details.sizeOfSeries; i++)
            {
                foreach (char ch in i_seriesOfBinary[i])
                {
                    if (ch == '1')
                    {
                        countOfOne++;
                    }
                }
            }

            return countOfOne / Details.sizeOfSeries;
        }
    }
}
