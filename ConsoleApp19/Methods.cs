using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Methods
    {
        internal static int ReadInt32(string caption, int min, int max)
        {
            int a;
        l1: Console.Write(caption, min, max);
            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("Please enter a number");
                goto l1;
            }

            if ((a >= min && a < max) == false) { Console.WriteLine("Please enter a number in the correct interval"); goto l1; }
            

            return a;
        }

        internal static int SumOfNumbers (int a) 
        {
            int lastNumb, sum = 0;
            while (a > 0)
            {
                lastNumb = a % 10;
                sum += lastNumb;
                a = a / 10;

            }
            return sum;
        }

        internal static int RevrseOfNumber (int a)
        {
            int reverse=0, lastNumber;
            while (a > 0)
            {
                lastNumber = a % 10;
                reverse=reverse*10+lastNumber;
                a = a / 10;

            }
            return reverse;
        }

    }
}
