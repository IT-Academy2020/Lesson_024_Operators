using System;

namespace ICloneableWork
{
    // Глибоке копіювання (Deep copy)

    public class Point : ICloneable
    {
        public int x, y;

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Реалізація методу інтерфейсу ICloneable.
        public object Clone()
        {
            return new Point(this.x, this.y) as object;
        }

        public override string ToString()
        {
            return "X:" + x + "Y:" + y;
        }
    }
}