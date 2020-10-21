using System;

// Використовувати ключове слово operator, можна тільки разом з ключовим словом static.

namespace Operators
{
    public struct Point
    {
        // Координати точки.
        private int x, y;

        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        // Перевантажений оператор ==.
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        // Перевантажений оператор! =.
        public static bool operator ! = (Point p1, Point p2)
        {
            return! p1.Equals (p2);
        }

    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.x, this.y);
    }

    // Перевизначення Equals ()
    // У вихідній реалізації, за замовчуванням, Equals () підтримує порівняння тільки посилальних типів.
    // Перевизначення його для порівняння структурних типів.
    public override bool Equals(object o)
    {
        if (o is Point)
        {
            if (((Point)o).x == this.x && ((Point)o).y == this.y)
                return true;
        }
        return false;
    }

    // Перевизначення GetHashCode () - обов'язкова при перевизначенні Equals ().
    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }
}
}