using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5SummInCursive1
{
    class Program
    {
        static void Main(string[] args)
        {
            task16();
            
        }

        public static void task16()
        {
            int[] deposit = { 25, 454, 322, 34, 56 };
            int[] TwoInctrase = deposit;
            int a = 0, sum = 0;
            foreach (var item in deposit)
            {
                Console.Write($"{item}\t");
                a = item * 2;
                TwoInctrase[item] = a;
                sum += item;
                
            }

            Console.WriteLine();

            foreach (var item in TwoInctrase)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            Console.Write($"{sum}\t");
        }
    }
}
