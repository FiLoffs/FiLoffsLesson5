using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Konspect1
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявляются три одномерных массива A,B,C
            int[] A = new int[5], B = new int[5], C = new int[5];
            Arrs.CreateOneDimAr(A);
            Arrs.CreateOneDimAr(B);
            for (int i = 0; i < 5; i++)
                C[i] = A[i] + B[i];
            //объявление массива с явной инициализацией
            int[] x = { 5, 5, 6, 6, 7, 7 };
            //объявление массивов с отложенной инициализацией
            int[] u, v;
            u = new int[3];
            for (int i = 0; i < 3; i++) u[i] = i + 1;
            //v= {1,2,3}; //присваивание константного массива
            //недопустимо
            v = new int[4];
            v = u; //допустимое присваивание
            int[,] w = new int[3, 5];
            //v=w; //недопустимое присваивание: объекты разных классов
            Arrs.PrintAr1("A", A); Arrs.PrintAr1("B", B);
            Arrs.PrintAr1("C", C); Arrs.PrintAr1("X", x);
            Arrs.PrintAr1("U", u); Arrs.PrintAr1("V", v);
        }        
    }
}
