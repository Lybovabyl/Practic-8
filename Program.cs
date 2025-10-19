using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double length = 0;
            double width = 0;
            Console.Write("Введите длину прямоугольника: ");

            if (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Ошибка: Длина и ширина должны быть положительными.");
                return;
            }
            Console.Write("Введите ширину прямоугольника: ");

            if (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Ошибка: длина и ширина должны быть положительными.");
                return;
            }
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
        }
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);

        }
    }
}  

