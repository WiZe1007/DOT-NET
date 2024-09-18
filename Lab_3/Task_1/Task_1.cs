using System; // Підключення простору імен System

class Task_1 // Оголошення класу Task_1
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть рядок:"); // Виведення запиту на введення рядка
        string input = Console.ReadLine(); // Зчитування введеного рядка

        Console.WriteLine("Введіть бажану довжину рядка:"); // Виведення запиту на введення бажаної довжини рядка
        int desiredLength = int.Parse(Console.ReadLine()); // Зчитування та перетворення введеної довжини в ціле число

        string result = JustifyString(input, desiredLength); // Виклик методу JustifyString для вирівнювання рядка
        Console.WriteLine($"Результат: >>{result}<<"); // Виведення результату

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static string JustifyString(string input, int desiredLength) // Метод для вирівнювання рядка
    {
        if (string.IsNullOrEmpty(input) || desiredLength <= input.Length) // Перевірка, чи рядок порожній або бажана довжина менша або дорівнює довжині рядка
        {
            return input; // Повернення початкового рядка, якщо умова виконується
        }

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Розбиття рядка на слова
        int totalSpaces = desiredLength - input.Length + (words.Length - 1); // Обчислення загальної кількості пробілів
        int spaceBetweenWords = totalSpaces / (words.Length - 1); // Обчислення кількості пробілів між словами
        int extraSpaces = totalSpaces % (words.Length - 1); // Обчислення залишкових пробілів

        string result = words[0]; // Ініціалізація результату першим словом

        for (int i = 1; i < words.Length; i++) // Цикл для додавання пробілів між словами
        {
            int spacesToAdd = spaceBetweenWords + (i <= extraSpaces ? 1 : 0); // Обчислення кількості пробілів для додавання
            result += new string(' ', spacesToAdd) + words[i]; // Додавання пробілів та наступного слова до результату
        }

        return result; // Повернення вирівняного рядка
    }
}

