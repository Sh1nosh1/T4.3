using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Задание 18.
                //Запросить у пользователя 5 слов, после чего вывести эти слова в одну строку, каждое через промежуток несколько символов от предыдущего.
                //Использовать 10 функции вывода.

                WriteLine("Введите 5 слов!");         //Запрашиваем у пользователя 5 слов
                Write("Введите первое слово: ");
                string word_1 = ReadLine();
                Write("Введите второе слово: ");
                string word_2 = ReadLine();
                Write("Введите третье слово: ");
                string word_3 = ReadLine();
                Write("Введите четвертое слово: ");
                string word_4 = ReadLine();
                Write("Введите пятое слово: ");
                string word_5 = ReadLine();

                Write($"{word_1}");   //Выводим эти слова и символы между ними, используя 10 функций вывода (10 раз использовать Write/WriteLine)
                Write(" !!! ");
                Write($"{word_2}");
                Write(" !!! ");
                Write($"{word_3}");
                Write(" !!! ");
                Write($"{word_4}");
                Write(" !!! ");
                Write($"{word_5}");
                Write(" !!! ");

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();


        }
    }
}
