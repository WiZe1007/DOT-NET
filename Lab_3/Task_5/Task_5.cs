using System; // Підключення базової бібліотеки System
using System.Text.RegularExpressions; // Підключення бібліотеки для роботи з регулярними виразами

class Task_5 // Оголошення класу Task_5
{
    static void Main() // Основний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть рядок:"); // Виведення запиту на введення рядка
        string input = Console.ReadLine(); // Зчитування введеного рядка

        string pattern = @"ий\b"; // Оголошення шаблону для пошуку (слова, що закінчуються на "ий")
        string replacement = "енький"; // Оголошення рядка для заміни

        string result = Regex.Replace(input, pattern, replacement); // Заміна знайдених шаблонів у введеному рядку

        Console.WriteLine("Результат: " + result); // Виведення результату

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }
}

