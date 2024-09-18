using System; // Підключення простору імен System
using System.Collections.Generic; // Підключення простору імен для роботи зі списками

class Task_3 // Оголошення класу Task_3
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть текстовий рядок:"); // Виведення запиту на введення тексту
        string text = Console.ReadLine(); // Зчитування введеного тексту
        char target = 'Ф'; // Визначення цільового символу
        List<int> positions = new List<int>(); // Створення списку для зберігання позицій

        for (int i = 0; i < text.Length; i++) // Цикл для проходження по всьому тексту
        {
            if (text[i] == target) // Перевірка, чи символ на поточній позиції дорівнює цільовому
            {
                positions.Add(i); // Додавання позиції до списку
            }
        }

        Console.WriteLine("Позиції входження букви 'Ф':"); // Виведення заголовку результатів
        foreach (int pos in positions) // Цикл для виведення всіх знайдених позицій
        {
            Console.WriteLine(pos); // Виведення поточної позиції
        }

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }
}

