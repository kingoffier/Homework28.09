using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите координаты точки");
             double x = Convert.ToDouble(Console.ReadLine());
             double y = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите переменную m - ");
             double m = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите переменную n - ");
             double n = Convert.ToDouble(Console.ReadLine());
             bool result = x >= m && x <= n;
             if (result)
             {
                    Console.WriteLine("Точка принадлежит части плоскости");
             }
             else
             {
                 Console.WriteLine("Точка не принадлежит части плоскости");
             }
             Console.ReadKey();
        }
    }
}
