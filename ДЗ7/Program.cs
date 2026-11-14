using System;

namespace Task_8_1
{
    class BankAccount
    {
        public string Owner;
        public decimal Balance;

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public void Transfer(BankAccount from, decimal sum)
        {
            if (from.Balance < sum)
            {
                Console.WriteLine($"Недостаточно средств на счёте {from.Owner}");
                return;
            }
            from.Balance -= sum;
            this.Balance += sum;
            Console.WriteLine($"Переведено {sum} от {from.Owner} к {this.Owner}");
        }

        public override string ToString()
        {
            return $"{Owner}: {Balance}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== УПРАЖНЕНИЕ 8.1 =====");

            BankAccount a = new BankAccount("Влад", 1000);
            BankAccount b = new BankAccount("Иван", 500);

            Console.WriteLine("До перевода:");
            Console.WriteLine("  " + a);
            Console.WriteLine("  " + b);

            b.Transfer(a, 300);

            Console.WriteLine("После перевода:");
            Console.WriteLine("  " + a);
            Console.WriteLine("  " + b);

        }
    }
}