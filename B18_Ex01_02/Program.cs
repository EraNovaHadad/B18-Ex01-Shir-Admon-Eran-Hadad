////-----------------------------------------------------------------------
////    Eran Hadad 204285209
////    Shir Admon 205641277
////    Sand Clock - 5 Lines - Drill -2-
////-----------------------------------------------------------------------

namespace B18_Ex01_02
{
    using System;
    using System.Text;

    // $G$ CSS-013 (-5) Bad variable name (should be in the form of i_PascalCase).
    // $G$ NTT-999 (-10) You should have used Environment.NewLine instead of "\n".

    public class Program
    {
        public static void Main()
        {
            string sandClock = CreateSandClock(5);
            Console.WriteLine(sandClock); ////One and only Write Line method calling
        }

        public static string CreateSandClock(int i_numOfLines)
        {
            StringBuilder buildsandClock = new StringBuilder();
            ////the format of sand clock must be odd number of lines
            if (i_numOfLines % 2 == 0)
            {
                i_numOfLines++;
            }

            for (int i = i_numOfLines; i > i_numOfLines / 2; i--)
            {
                buildsandClock.Append(' ', i_numOfLines - i);
                buildsandClock.Append('*', i_numOfLines - ((i_numOfLines - i) * 2));
                buildsandClock.Append('\n', 1);
            }

            for (int j = 1; j < (i_numOfLines / 2) + 1; j++)
            {
                buildsandClock.Append(' ', (i_numOfLines / 2) - j);
                buildsandClock.Append('*', (j * 2) + 1);
                buildsandClock.Append('\n', 1);
            }

            return buildsandClock.ToString();
        }
    }
}