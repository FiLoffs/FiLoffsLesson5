using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Konspect2
{
    class Program
    {
        static void Main(string[] args)
        {
            //массив массивов -"Отцы и дети"
            int Fcount = 3;
            string[] Fathers = new string[Fcount];
            Fathers[0] = "Николай";
            Fathers[1] = "Сергей";
            Fathers[2] = "Петр";
            string[][] Children = new string[Fcount][];
            Children[0] = new string[] { "Ольга", "Федор" };
            Children[1] = new string[] {"Сергей","Валентина","Ира","Дмитрий"};
            Children[2] = new string[] { "Мария", "Ирина", "Надежда" };
            myar.PrintAr3(Fathers, Children);
        }
    }
}
