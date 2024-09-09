using System; // Підключення System.

class Task9 // Клас Task9.
{
    static void Main() // Головний метод.
    {
        for (int n = 0; n < 5; n++) // Цикл 5 разів.
        {
            Console.WriteLine("|   x   |      y     |"); // Заголовок таблиці.
            Console.WriteLine("|-------|------------|"); // Роздільник таблиці.

            for (double x = 0; x < 4; x += 0.25) // Цикл для x.
            {
                double y; // Значення y.
                if (x < 1) // Якщо x < 1.
                    y = 2 * x - 1; // y = 2x - 1.
                else if (x < 3) // Якщо x < 3.
                    y = 1 - Math.Sqrt(1 - (x - 2) * (x - 2)); // y = 1 - sqrt(1 - (x - 2)²).
                else // Якщо x >= 3.
                    y = 7 - 2 * x; // y = 7 - 2x.

                Console.Write($"| {x + n * 4,5:0.00} | {y,10:0.0000000} |"); // Вивід x і y.

                int h = (int)((y + 1) * 10); // Обчислення h.
                if (y - 1 - h * 10 > 0.5) h++; // Коригування h.

                for (int i = 0; i < h; i++) Console.Write(" "); // Пробіли для графіку.
                Console.WriteLine("*"); // Символ '*' для графіку.
            }

            Console.WriteLine("Натисніть клавішу Enter..."); // Запрос на Enter.
            Console.ReadLine(); // Очікування Enter.
        }
    }
}

