using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности: ");
            Console.Write("l=");
            double l = double.Parse(Console.ReadLine());
            double S = Math.Pow(l, 2) / 4 * Math.PI;
            Console.WriteLine("Площадь круга: ");
            Console.WriteLine("S= {0} " ,S);
            Console.ReadKey();
        }
    }
}
