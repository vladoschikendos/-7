using System;
using System.IO;

namespace Task_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== УПРАЖНЕНИЕ 8.3 =====");

            Console.Write("Введите полный путь к файлу: ");
            string input = Console.ReadLine();

            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не существует. Работа завершена.");
                Console.ReadKey();
                return;
            }

            string output = "output.txt";
            string content = File.ReadAllText(input);
            File.WriteAllText(output, content.ToUpper());

            Console.WriteLine($"Содержимое записано в {output} заглавными буквами.");

            Console.ReadKey();
        }
    }
}