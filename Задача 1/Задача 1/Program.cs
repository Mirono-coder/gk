
using System;

namespace Задача_1
{
    class Program
    {

        static void Main(string[] args)
        {
            oper oop = new oper();
            Console.WriteLine("введите х");
            string x1 = Console.ReadLine();
            double x = Convert.ToDouble(x1);
            Console.WriteLine("Введите у");
            string x2 = Console.ReadLine();
            double y = Convert.ToDouble(x2);
            oop.sum(x, y);
            oop.raz(x, y);
            oop.pro(x, y);
            oop.del(x, y);
            Console.WriteLine();

        }
    }
    class oper
    {
        double x;
        double y;
        public void sum(double x, double y)
        {
            x = x + y;
            Console.WriteLine(x);

        }
        public void raz(double x, double y)
        {
            x = x - y;
            Console.WriteLine(x);
        }
        public void pro(double x, double y)
        {
            x = x * y;
            Console.WriteLine(x);
        }
        public void del(double x, double y)
        {
            x = x / y;
            Console.WriteLine(x);

        }
    }
}
