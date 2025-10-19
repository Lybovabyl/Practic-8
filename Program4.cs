using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.Write("Введите строку: ");
            inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Ошибка: строка пуста или содержит только пробелы.");
                return;
            }
            string firstWord;
            int wordCount;
            bool success = SplitIntoWords(inputString, out firstWord, out wordCount);

            if (success)
            {
                Console.WriteLine($"Первое слово: {firstWord}");
                Console.WriteLine($"Количество слов: {wordCount}");
            }
        }
        public static bool SplitIntoWords(string str, out string firstWord, out int wordCount)
        {
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                firstWord = words[0];
                wordCount = words.Length;
                return true;
            }
            else
            {
                firstWord = null;
                wordCount = 0;
                return false;
            }
        }
    }
}
    
