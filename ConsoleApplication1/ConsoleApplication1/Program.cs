using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello github");
            Console.WriteLine(Square(4));
            Console.WriteLine(Pow(2, 3));
            Console.WriteLine(IsPrime(8));
            Console.WriteLine(IsEven(3));
            Console.WriteLine(Floor(4.4F));
            Console.WriteLine(Cube(-10));
            Console.WriteLine(Ceil(4.6F));
            Console.WriteLine(Abs(6));
            Console.WriteLine(Factorial(20L));

            Console.ReadKey();
        }
        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }
        static int Abs(int n)
        {
            if (n < 0)
            {
                n = n * (-1);
            }
            return n;
        }
        static int Ceil(float x)
        {
            int n = (int)x;
            if ((n - x) <= 0.5)
                n = n + 1;
            return n;

            //int d = (int)(x + 0.5);
            //return d;
        }
        static int Cube(int n)
        {
            return n * n * n;
        }
        static int Floor(float x)
        {
            int d = (int)(x + 0.5);
            return d;
        }
        static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < n; i++) if (n % i == 0)
                {
                    return false;
                }
            return true;
        }
        static int Pow(int x, int y)
        {
            int rs = 1;
            for (int i = 1; i <= y; i++)
                rs = rs * x;
            return rs;
        }
        static int Square(int n)
        {
            return n * n;
        }
        static long Factorial(long n)
        {
            int F = 1;
            for (int i = 2; i < n; i++)
                F = F * i;
            return F;
        }

    }
}
