using System; // Підключення простору імен System

class Task_2 // Оголошення класу Task_2
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        string input; // Оголошення змінної для вводу рядка
        int start, count; // Оголошення змінних для номера слова та кількості слів

        while (true) // Безкінечний цикл
        {
            Console.Write("Введіть рядок > "); // Вивід запиту на ввід рядка
            input = Console.ReadLine(); // Зчитування вводу користувача
            if (input == "***") break; // Перевірка на умову завершення циклу

            Console.Write("Введіть номер слова та кількість слів для видалення > "); // Запит на ввід параметрів
            if (!int.TryParse(Console.ReadLine(), out start) || !int.TryParse(Console.ReadLine(), out count)) // Перевірка коректності вводу параметрів
            {
                Console.WriteLine("Некоректні параметри."); // Вивід повідомлення про помилку
                continue; // Повернення до початку циклу
            }

            string result = RemoveWords(input, start, count); // Виклик методу для видалення слів
            Console.WriteLine($"Результат: {result}"); // Вивід результату
        }

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static string RemoveWords(string input, int start, int count) // Метод для видалення слів з рядка
    {
        if (start < 1 || count < 0) return "Помилка в параметрах."; // Перевірка коректності параметрів

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Розбиття рядка на слова
        if (start > words.Length) return "Помилка в параметрах."; // Перевірка коректності параметра start

        int end = Math.Min(start + count - 1, words.Length); // Обчислення кінцевого індексу для видалення
        string[] resultWords = new string[words.Length - (end - start + 1)]; // Створення нового масиву для результату
        Array.Copy(words, 0, resultWords, 0, start - 1); // Копіювання слів до початку видалення
        Array.Copy(words, end, resultWords, start - 1, words.Length - end); // Копіювання слів після видалення

        return string.Join(" ", resultWords); // Об'єднання слів у рядок та повернення результату
    }
}

