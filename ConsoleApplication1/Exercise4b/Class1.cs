using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4b
{
    class Drawing
    {
        private static void Setup(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                {
                    arr[d, c] = ' ';
                }
            }
        }
        private static void Print(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(" " + arr[d, c]);
                }
            } Console.WriteLine();
        }
        public static void drawU(int n)
        {

        }
    }
}
