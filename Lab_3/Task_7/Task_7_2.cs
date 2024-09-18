using System; // Підключення простору імен System
using System.IO; // Підключення простору імен для роботи з файлами

class Task_7_2 // Оголошення класу Task_7_2
{
    static void Main() // Головний метод програми
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

        string input = File.ReadAllText(inputFilePath); // Читання вмісту вхідного файлу

        Console.Write("Введіть номер слова та кількість слів для видалення: "); // Запит на введення даних
        int start = int.Parse(Console.ReadLine()); // Зчитування та перетворення введеного номера слова
        int count = int.Parse(Console.ReadLine()); // Зчитування та перетворення кількості слів для видалення

        string result = RemoveWords(input, start, count); // Виклик методу для видалення слів
        File.WriteAllText(outputFilePath, result); // Запис результату у вихідний файл

        Console.WriteLine($"Результат записано в файл {outputFilePath}"); // Виведення повідомлення про успішний запис

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static string RemoveWords(string input, int start, int count) // Метод для видалення слів
    {
        if (start < 1 || count < 0) // Перевірка коректності параметрів
        {
            return "Помилка в параметрах."; // Повернення повідомлення про помилку
        }

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Розбиття тексту на слова
        if (start > words.Length) // Перевірка, чи не виходить номер слова за межі масиву
        {
            return "Помилка в параметрах."; // Повернення повідомлення про помилку
        }

        int end = Math.Min(start + count - 1, words.Length); // Обчислення кінцевого індексу для видалення
        string[] resultWords = new string[words.Length - (end - start + 1)]; // Створення нового масиву для результату
        Array.Copy(words, 0, resultWords, 0, start - 1); // Копіювання слів до початку видалення
        Array.Copy(words, end, resultWords, start - 1, words.Length - end); // Копіювання слів після видалення

        return string.Join(" ", resultWords); // Об'єднання слів у рядок та повернення результату
    }
}

