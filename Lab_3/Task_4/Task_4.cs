using System; // Підключення простору імен System

class Task_4 // Оголошення класу Task_4
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть текстовий рядок:"); // Виведення запиту на введення тексту
        string input = Console.ReadLine(); // Зчитування введеного тексту
        string result = DoubleLetters(input); // Виклик методу DoubleLetters для обробки тексту
        Console.WriteLine("Результат: " + result); // Виведення результату

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static string DoubleLetters(string input) // Метод для подвоєння певних літер у рядку
    {
        string lettersToDouble = "лнсо"; // Літери, які потрібно подвоїти
        string result = ""; // Змінна для збереження результату

        foreach (char c in input) // Прохід по кожному символу вхідного рядка
        {
            result += c; // Додавання символу до результату
            if (lettersToDouble.Contains(c)) // Перевірка, чи символ є в списку літер для подвоєння
            {
                result += c; // Додавання символу ще раз, якщо він є в списку
            }
        }

        return result; // Повернення результату
    }
}

