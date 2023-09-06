using System;

namespace KatyaIS_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = 1;
            int ball = 0;
            while (i <= 3)
            {
                Console.WriteLine($"Поптыка: {i}");
                Console.Write("Введите число: ");
                int pol = int.Parse(Console.ReadLine());

                int p1 = rnd.Next(1, 24);
                int p2 = rnd.Next(1, 24);
                int p3 = rnd.Next(1, 24);
                Console.WriteLine($"Программа: {p1} {p2} {p3}");
                if ((pol == p1) || (pol == p2) || (pol == p3))
                {
                    Console.WriteLine("1 балл");
                    i += 1;
                    ball += 1;
                }
                else
                {
                    i += 1;
                }
            }
            if (ball >= 2)
            {
                Console.WriteLine("Вы выиграли");
            }
            else
            {
                Console.WriteLine("Вы проиграли");

            }
            Console.ReadLine();
        }
    }
}
