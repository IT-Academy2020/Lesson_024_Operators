using System;

// перевантаження оператора явного превращение типу.

// ключовими словами explicit служити для создания оператора явного превращение типу.

namespace MyNamespace
{
    struct Digit
    {
        public byte value;

        // Конструктор.
        Digit(byte value)
        {
            this.value = value;
        }

        // Оператор явного превращение типу byte-to-Digit.
        public static explicit operator Digit(byte argument)
        {
            Digit digit = new Digit(argument);
            return digit;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }

    class MainClass
    {
        static void Main()
        {
            byte variable = 1;

            // Явне превращение byte-to-Digit.
            Digit digit = (Digit)variable;

            Console.WriteLine(digit);

            // Delay.
            Console.ReadKey();
        }
    }
}