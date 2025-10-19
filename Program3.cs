using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                int num;
                int increment;


                Console.Write("Введите число: ");
                string inputNum = Console.ReadLine();

                if (int.TryParse(inputNum, out num))                        
                Console.Write("Введите величину увеличения: ");
                string inputIncrement = Console.ReadLine();

                if (!int.TryParse(inputIncrement, out increment))
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                    return;
                }

                if (increment < 0)
                {
                    Console.WriteLine("Ошибка: величина увеличения должна быть неотрицательной.");
                    return;
                }

                Console.WriteLine($"До увеличения: {num}");

                IncreaseNum(ref num, increment);

                Console.WriteLine($"После увеличения: {num}");
            }
        }

        private static void IncreaseNum(ref int num, int increase)
        {
            num += increase;
        }
    }
}
    

                
