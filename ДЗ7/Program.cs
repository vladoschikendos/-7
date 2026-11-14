using System;

namespace Task_8_4
{
    internal class Program
    {
        static bool IsFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable f = obj as IFormattable;
                return f != null;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== УПРАЖНЕНИЕ 8.4 =====");

            object[] objects = { 123, "строка", 3.14, new object(), DateTime.Now };

            foreach (object o in objects)
            {
                Console.WriteLine($"{o} ({o.GetType().Name}) реализует IFormattable: {IsFormattable(o)}");
            }

            Console.ReadKey();
        }
    }
}