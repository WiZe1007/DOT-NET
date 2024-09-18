using System; // Підключення простору імен System
using System.IO; // Підключення простору імен для роботи з файлами

class Task_7_1 // Оголошення класу Task_7_1
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        string inputFilePath = "input.txt"; // Шлях до вхідного файлу
        string outputFilePath = "output.txt"; // Шлях до вихідного файлу

        if (!File.Exists(inputFilePath)) // Перевірка існування вхідного файлу
        {
            Console.WriteLine("Файл input.txt не знайдено."); // Виведення повідомлення про відсутність файлу
            return; // Завершення виконання програми
        }

        string input = File.ReadAllText(inputFilePath); // Читання вмісту вхідного файлу

        Console.WriteLine("Введіть бажану довжину рядка:"); // Запит на введення бажаної довжини рядка
        int desiredLength = int.Parse(Console.ReadLine()); // Зчитування та перетворення введеного значення в ціле число

        string result = JustifyString(input, desiredLength); // Вирівнювання рядка до бажаної довжини
        File.WriteAllText(outputFilePath, result); // Запис результату у вихідний файл

        Console.WriteLine($"Результат записано в файл {outputFilePath}"); // Виведення повідомлення про успішний запис

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static string JustifyString(string input, int desiredLength) // Метод для вирівнювання рядка
    {
        if (string.IsNullOrEmpty(input) || desiredLength <= input.Length) // Перевірка на порожній рядок або недостатню довжину
        {
            return input; // Повернення вхідного рядка без змін
        }

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Розбиття рядка на слова
        int totalSpaces = desiredLength - input.Length + (words.Length - 1); // Обчислення загальної кількості пробілів
        int spaceBetweenWords = totalSpaces / (words.Length - 1); // Обчислення кількості пробілів між словами
        int extraSpaces = totalSpaces % (words.Length - 1); // Обчислення додаткових пробілів

        string result = words[0]; // Початкове значення результату - перше слово

        for (int i = 1; i < words.Length; i++) // Цикл для додавання пробілів між словами
        {
            int spacesToAdd = spaceBetweenWords + (i <= extraSpaces ? 1 : 0); // Обчислення кількості пробілів для додавання
            result += new string(' ', spacesToAdd) + words[i]; // Додавання пробілів та наступного слова до результату
        }

        return result; // Повернення вирівняного рядка
    }
}

