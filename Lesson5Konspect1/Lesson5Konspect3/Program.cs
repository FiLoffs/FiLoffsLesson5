using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        // Данный метод возвращает кортеж с 4-мя
        // разными значениями
        static Tuple<int, float, string, char> Corteg(int a, string name)
        {
            int sqr = a * a;
            float sqrt = (float)(Math.Sqrt(a));
            string s = "Привет, " + name;
            char ch = (char)(name[0]);
            return Tuple.Create<int, float, string, char>(sqr, sqrt, s, ch);
        }
        static void Main(string[] args)
        {
            var myTuple = Corteg(25, "Сергей");
            Console.WriteLine("{0}\n25 в квадрате: {1}\nКвадратный корень из 25: " + "{2}\nПервый символ в имени: {3}\n", 
                myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);
            // Создаем кортеж произвольной размерности
            var myTuple2 = Tuple.Create<int, char, string, decimal, float, byte, short,
            Tuple<int, float, string, char>>(12, 'C', "Name", 12.3892m, 0.5f, 120, 4501, myTuple);
            Console.ReadLine();
        }
    }
    public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
    {
    }
}