////-----------------------------------------------------------------------
////    Eran Hadad 204285209
////    Shir Admon 205641277
////    Sand Clock - n-th Lines - Drill -3-
////-----------------------------------------------------------------------

namespace B18_Ex01_03
{
    using System;
    using System.Text;
    using B18_Ex01_02;

    public class Program
    {
        public static void Main()
        {
            expertSandClock();
        }

        private static void expertSandClock()
        {
            int numberOfLines;

            Console.WriteLine("Please enter the number of lines for your sand clock: ");
            string inputFromUser = Console.ReadLine();
            ////check if it is possible to convert the input from string to int
            while (!int.TryParse(inputFromUser, out numberOfLines))
            {
                Console.WriteLine("You entered illegal input, Please enter the number of lines for your sand clock: ");
                inputFromUser = Console.ReadLine();
            }

            string sandClock = B18_Ex01_02.Program.CreateSandClock(numberOfLines);
            Console.WriteLine(sandClock);
        }
    }
}