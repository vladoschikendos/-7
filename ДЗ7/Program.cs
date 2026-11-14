using System;
using System.Collections.Generic;
using System.IO;

namespace Task_8_1_Home
{
    internal class Program
    {
        public static void SearchMail(ref string s)
        {
            int idx = s.IndexOf('#');
            if (idx >= 0)
                s = s.Substring(idx + 1).Trim();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== ДОМАШНЕЕ ЗАДАНИЕ 8.1 =====");

            string inputFile = "fio_mail.txt";
            if (!File.Exists(inputFile))
            {
                File.WriteAllLines(inputFile, new[]
                {
                    "Иванов Иван Иванович # iviviv@mail.ru",
                    "Петров Петр Петрович # petr@mail.ru"
                });
                Console.WriteLine($"Создан файл {inputFile}");
            }

            string[] lines = File.ReadAllLines(inputFile);
            List<string> emails = new List<string>();

            foreach (string line in lines)
            {
                string s = line;
                SearchMail(ref s);
                emails.Add(s);
            }

            File.WriteAllLines("emails.txt", emails);

            Console.WriteLine("Список адресов записан в emails.txt:");
            foreach (string e in emails)
                Console.WriteLine("  " + e);

            Console.ReadKey();
        }
    }
}