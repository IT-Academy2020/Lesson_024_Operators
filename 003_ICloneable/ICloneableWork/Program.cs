using System;

namespace ICloneableWork
{
    class Program
    {
        static void Main()
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("Перша перевірка");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Змінюємо clone.x (при цьому original.x не зміниться)
            clone.x = 0;

            // Перевірка.
            Console.WriteLine("Друга перевірка після зміни");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Delay.
            Console.ReadKey();
        }
    }
}