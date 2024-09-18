using System; // Підключення простору імен System
using System.IO; // Підключення простору імен System.IO

class Task_8_1 // Оголошення класу Task_8_1
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть текстовий рядок:"); // Виведення запиту на введення тексту
        string input = Console.ReadLine(); // Зчитування введеного тексту
        string result = DoubleLetters(input); // Виклик методу DoubleLetters для обробки тексту

        // Запис результату у двійковий файл
        using (BinaryWriter writer = new BinaryWriter(File.Open("result4.bin", FileMode.Create))) // Створення двійкового файлу для запису
        {
            writer.Write(result); // Запис результату у файл
        }

        // Читання результату з двійкового файлу
        using (BinaryReader reader = new BinaryReader(File.Open("result4.bin", FileMode.Open))) // Відкриття двійкового файлу для читання
        {
            string fileContent = reader.ReadString(); // Зчитування вмісту файлу
            Console.WriteLine("Результат з файлу: " + fileContent); // Виведення результату на екран
        }

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static string DoubleLetters(string input) // Метод для подвоєння певних літер у тексті
    {
        string lettersToDouble = "лнсо"; // Літери, які потрібно подвоїти
        string result = ""; // Рядок для збереження результату

        foreach (char c in input) // Прохід по кожному символу вхідного рядка
        {
            result += c; // Додавання символу до результату
            if (lettersToDouble.Contains(c)) // Перевірка, чи символ є у списку літер для подвоєння
            {
                result += c; // Додавання символу ще раз, якщо він є у списку
            }
        }

        return result; // Повернення результату
    }
}

