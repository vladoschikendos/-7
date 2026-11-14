using System;

namespace Task_8_2
{
    internal class Program
    {
        static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== УПРАЖНЕНИЕ 8.2 =====");

            Console.Write("Введите строку: ");
            string s = Console.ReadLine();

            Console.WriteLine("В обратном порядке: " + Reverse(s));

            Console.ReadKey();
        }
    }
}