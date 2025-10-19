using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите число n (0-20): ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 20)
            {
                Console.WriteLine("Ошибка: число должно быть в диапазоне 0-20.");
                return;
            }
            long factorial = CalculateFactorial(n);
            Console.WriteLine($"Факториал {n}! = {factorial}");
        }

        public static long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
    

