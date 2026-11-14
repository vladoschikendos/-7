using System;
using System.Collections.Generic;

namespace Task_8_2_Home
{
    class Song
    {
        string name;
        string author;
        public Song prev;

        public void SetName(string n) { name = n; }
        public void SetAuthor(string a) { author = a; }
        public void SetPrev(Song p) { prev = p; }

        public string Title()
        {
            return $"{name} — {author}";
        }

        public void Print()
        {
            Console.WriteLine($"Песня: {name}, исполнитель: {author}");
        }

        public override bool Equals(object d)
        {
            if (d is Song other)
                return this.name == other.name && this.author == other.author;
            return false;
        }

        public override int GetHashCode()
        {
            return (name + author).GetHashCode();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ДОМАШНЕЕ ЗАДАНИЕ 8.2 =====");

            List<Song> songs = new List<Song>();

            Song s1 = new Song();
            s1.SetName("Кукла колдуна"); s1.SetAuthor("Король и Шут");
            songs.Add(s1);

            Song s2 = new Song();
            s2.SetName("Группа крови"); s2.SetAuthor("Кино");
            songs.Add(s2);

            Song s3 = new Song();
            s3.SetName("Кукла колдуна"); s3.SetAuthor("Король и Шут");
            songs.Add(s3);

            Song s4 = new Song();
            s4.SetName("Владимирский централ"); s4.SetAuthor("Михаил Круг");
            songs.Add(s4);

            s1.SetPrev(null);
            s2.SetPrev(s1);
            s3.SetPrev(s2);
            s4.SetPrev(s3);

            Console.WriteLine("Список песен:");
            foreach (Song song in songs)
                song.Print();

            Console.WriteLine("\nСравнение первой и второй песни:");
            if (songs[0].Equals(songs[1]))
                Console.WriteLine("  Песни одинаковые");
            else
                Console.WriteLine("  Песни разные");

            Console.WriteLine("\nСравнение первой и третьей песни:");
            if (songs[0].Equals(songs[2]))
                Console.WriteLine("  Песни одинаковые");
            else
                Console.WriteLine("  Песни разные");

            Console.ReadKey();
        }
    }
}