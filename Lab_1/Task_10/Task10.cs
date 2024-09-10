using System;

class Task10
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування UTF-8

        Console.ForegroundColor = ConsoleColor.Yellow; // Жовтий текст
        Console.WriteLine("|   x   |      y     |"); // Заголовок таблиці
        Console.WriteLine("|-------|------------|"); // Розділювач таблиці
        Console.ResetColor(); // Скидання кольору

        for (int n = 0; n < 5; n++) // Цикл для рядків
        {
            for (double x = 0; x < 4; x += 0.25) // Цикл для x
            {
                double y; // Значення y
                if (x < 1) // Перша формула
                    y = 2 * x - 1;
                else if (x < 3) // Друга формула
                    y = 1 - Math.Sqrt(1 - (x - 2) * (x - 2));
                else // Третя формула
                    y = 7 - 2 * x;

                Console.ForegroundColor = ConsoleColor.Cyan; // Блакитний текст
                Console.Write($"| {x + n * 4,5:0.00} | {y,10:0.0000000} |"); // Виведення x і y
                Console.ResetColor(); // Скидання кольору

                int h = (int)((y + 1) * 10 / 2); // Висота графіка

                Console.ForegroundColor = ConsoleColor.Green; // Зелений текст для графіка

                // Виведення графіка з псевдографікою
                for (int i = 0; i < h; i++)
                {
                    Console.Write(" ");
                }

                if (y > 0) // Позитивний y
                    Console.WriteLine("/");
                else if (y < 0) // Негативний y
                    Console.WriteLine("\\");
                else // Нульовий y
                    Console.WriteLine("|");

                Console.ResetColor(); // Скидання кольору
            }

            Console.ForegroundColor = ConsoleColor.Magenta; // Магентовий текст
            Console.WriteLine("Натисніть клавішу Enter..."); // Запрошення натиснути Enter
            Console.ResetColor(); // Скидання кольору
            Console.ReadLine(); // Очікування Enter
        }
    }
}

