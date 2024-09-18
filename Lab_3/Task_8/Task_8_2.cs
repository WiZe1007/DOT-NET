using System; // Підключення простору імен System
using System.IO; // Підключення простору імен для роботи з файлами
using System.Text.RegularExpressions; // Підключення простору імен для роботи з регулярними виразами

class Task_8_2 // Оголошення класу Task_8_2
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть рядок:"); // Виведення запиту на введення рядка
        string input = Console.ReadLine(); // Зчитування введеного рядка

        string pattern = @"ий\b"; // Оголошення шаблону для пошуку
        string replacement = "енький"; // Оголошення рядка для заміни

        string result = Regex.Replace(input, pattern, replacement); // Заміна шаблону в введеному рядку

        // Запис результату у двійковий файл
        using (BinaryWriter writer = new BinaryWriter(File.Open("result5.bin", FileMode.Create))) // Відкриття файлу для запису
        {
            writer.Write(result); // Запис результату у файл
        }

        // Читання результату з двійкового файлу
        using (BinaryReader reader = new BinaryReader(File.Open("result5.bin", FileMode.Open))) // Відкриття файлу для читання
        {
            string fileContent = reader.ReadString(); // Зчитування вмісту файлу
            Console.WriteLine("Результат з файлу: " + fileContent); // Виведення результату на екран
        }

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }
}

