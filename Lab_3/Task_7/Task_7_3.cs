using System; // Підключення простору імен System
using System.IO; // Підключення простору імен для роботи з файлами
using System.Collections.Generic; // Підключення простору імен для використання колекцій

class Task_7_3
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        string inputFilePath = "input.txt"; // Шлях до вхідного файлу
        string outputFilePath = "output.txt"; // Шлях до вихідного файлу

        if (!File.Exists(inputFilePath)) // Перевірка наявності вхідного файлу
        {
            Console.WriteLine("Файл input.txt не знайдено."); // Виведення повідомлення про відсутність файлу
            return; // Завершення виконання програми
        }

        string text = File.ReadAllText(inputFilePath); // Читання всього тексту з вхідного файлу
        char target = 'Ф'; // Символ, який шукаємо у тексті
        List<int> positions = new List<int>(); // Список для збереження позицій символу

        for (int i = 0; i < text.Length; i++) // Прохід по всьому тексту
        {
            if (text[i] == target) // Перевірка, чи символ у тексті відповідає цільовому символу
            {
                positions.Add(i); // Додавання позиції символу до списку
            }
        }

        using (StreamWriter writer = new StreamWriter(outputFilePath)) // Відкриття вихідного файлу для запису
        {
            writer.WriteLine("Позиції входження букви 'Ф':"); // Запис заголовку у файл
            foreach (int pos in positions) // Прохід по всіх знайдених позиціях
            {
                writer.WriteLine(pos); // Запис позиції у файл
            }
        }

        Console.WriteLine($"Результат записано в файл {outputFilePath}"); // Виведення повідомлення про успішний запис

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }
}

