using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();

            Console.Write("Введите минимальную длину: ");
            string lengthInput = Console.ReadLine();

            if (int.TryParse(lengthInput, out int minLength) && minLength > 0)
            {
                bool isLongEnough = IsStringLongEnough(inputString, minLength);

                if (isLongEnough)
                {
                    Console.WriteLine($"Строка '{inputString}' достаточно длинная.");
                }
                else
                {
                    Console.WriteLine($"Строка '{inputString}' слишком короткая.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: строка пуста ");
            }
        }

        static bool IsStringLongEnough(string str, int minLength)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Ошибка: строка пуста или null.");
                return false;
            }

            return str.Length >= minLength;
        }
    }


}
