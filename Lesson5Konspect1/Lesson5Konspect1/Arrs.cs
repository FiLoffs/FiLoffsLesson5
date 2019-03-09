using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Konspect1
{
    class Arrs
    {
        private static Random rnd = new Random();

        public static void CreateOneDimAr(int[] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                A[i] = rnd.Next(1, 100);
        }//CreateOneDimAr

        public static void PrintAr1(string name, int[] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
                Console.Write("\t" + name + "[{0}]={1}", i, A[i]);
            Console.WriteLine();
        }//PrintAr1
    }
}
