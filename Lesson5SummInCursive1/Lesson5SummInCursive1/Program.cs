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
            //int N = 
            //string
            int[] deposit = { 25, 454, 322, 34, 56 };
            int a = 0, sum = 0;
            foreach (var item in deposit)
            {
                Console.Write($"{item}\t");
                a = item * 2;
                Console.Write($"{a}\t");
                sum += item;
                Console.Write($"{sum}\t");
            }
            Console.WriteLine();
        }
    }
}
