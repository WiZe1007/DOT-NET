using System;
using System.Text;

class Task2
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Встановлення кодування UTF-8 для правильної роботи з псевдографікою
        Console.OutputEncoding = Encoding.UTF8;

        // Оголошення масивів для зберігання даних про транспорт
        string[] transportType = new string[3]; // Масив для виду транспорту
        string[] routeNumber = new string[3];   // Масив для номерів маршрутів
        double[] routeLength = new double[3];   // Масив для довжини маршруту
        int[] travelTime = new int[3];          // Масив для часу в дорозі

        // Введення даних користувачем
        for (int i = 0; i < 3; i++)
        {
            // Запит даних для кожного виду транспорту
            Console.WriteLine($"Введіть дані для транспорту {i + 1}:");

            // Запит виду транспорту
            Console.Write("Вид транспорту (Тр, Тл, А): ");
            transportType[i] = Console.ReadLine();

            // Запит номера маршруту
            Console.Write("Номер маршруту: ");
            routeNumber[i] = Console.ReadLine();

            // Запит протяжності маршруту в кілометрах
            Console.Write("Протяжність маршруту (км): ");
            routeLength[i] = Convert.ToDouble(Console.ReadLine());

            // Запит часу в дорозі в хвилинах
            Console.Write("Час в дорозі (хвилин): ");
            travelTime[i] = Convert.ToInt32(Console.ReadLine());

            // Порожній рядок для відділення введень
            Console.WriteLine();
        }

        // Встановлення кольорів для виведення таблиці
        Console.ForegroundColor = ConsoleColor.Cyan;

        // Виведення верхньої частини таблиці з псевдографікою
        Console.WriteLine("┌───────────────────────────────────────────────────────────┐");
        Console.WriteLine("│                Відомості суспільного транспорту           │");
        Console.WriteLine("├────────────────┬────────────┬──────────────────┬──────────┤");

        // Виведення заголовків колонок таблиці
        Console.WriteLine("│ Вид транспорту │ № маршруту │ Протяжність (км) │ Час (хв) │");
        Console.WriteLine("├────────────────┼────────────┼──────────────────┼──────────┤");

        // Цикл для виведення даних по кожному виду транспорту
        for (int i = 0; i < transportType.Length; i++)
        {
            // Виведення даних з різними кольорами для кожної колонки
            Console.Write("│ ");
            Console.ForegroundColor = ConsoleColor.Yellow; // Жовтий для виду транспорту
            Console.Write($"{transportType[i],-14}");
            Console.ForegroundColor = ConsoleColor.Cyan;   // Блакитний для розділення
            Console.Write(" │ ");
            Console.ForegroundColor = ConsoleColor.Green;  // Зелений для номера маршруту
            Console.Write($"{routeNumber[i],-10}");
            Console.ForegroundColor = ConsoleColor.Cyan;   // Блакитний для розділення
            Console.Write(" │ ");
            Console.ForegroundColor = ConsoleColor.Magenta;// Пурпурний для протяжності
            Console.Write($"{routeLength[i],-16}");
            Console.ForegroundColor = ConsoleColor.Cyan;   // Блакитний для розділення
            Console.Write(" │ ");
            Console.ForegroundColor = ConsoleColor.Red;    // Червоний для часу в дорозі
            Console.Write($"{travelTime[i],-8}");
            Console.ForegroundColor = ConsoleColor.Cyan;   // Блакитний для завершення рядка
            Console.WriteLine(" │");
        }

        // Завершення таблиці та примітки
        Console.WriteLine("├────────────────┴────────────┴──────────────────┴──────────┤");
        Console.WriteLine("│ Примітка: Тр – трамвай, Тл – тролейбус, А – автобус       │");
        Console.WriteLine("└───────────────────────────────────────────────────────────┘");

        // Скидання кольорів консолі до значень за замовчуванням
        Console.ResetColor();

        Console.ReadLine();  // Затримка перед закриттям програми
    }
}

