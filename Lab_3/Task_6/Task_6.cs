using System; // Підключення простору імен System
using System.Linq; // Підключення простору імен LINQ для роботи з колекціями
using System.Text.RegularExpressions; // Підключення простору імен для роботи з регулярними виразами
using System.Collections.Generic; // Підключення простору імен для роботи з колекціями

class Task_6
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть текстовий рядок:"); // Виведення запиту на введення рядка
        string input = Console.ReadLine(); // Зчитування введеного рядка

        // Завдання а)
        var result = CountWordsWithEqualVowelsAndConsonants(input); // Підрахунок слів з однаковою кількістю голосних і приголосних
        Console.WriteLine($"Кількість слів з однаковою кількістю голосних і приголосних літер: {result.count} ({string.Join(", ", result.words)})"); // Виведення результату

        // Завдання б)
        string longestWord = FindLongestWord(input); // Пошук найдовшого слова
        Console.WriteLine($"Найдовше слово: {longestWord}"); // Виведення найдовшого слова

        // Завдання в)
        string resultWithoutPalindromes = RemovePalindromes(input); // Видалення слів-паліндромів
        Console.WriteLine($"Текст без слів-паліндромів: {resultWithoutPalindromes}"); // Виведення результату без паліндромів

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static (int count, List<string> words) CountWordsWithEqualVowelsAndConsonants(string input)
    {
        string[] words = Regex.Split(input, @"\W+"); // Розбиття рядка на слова за допомогою регулярного виразу
        int count = 0; // Лічильник слів
        List<string> equalWords = new List<string>(); // Список слів з однаковою кількістю голосних і приголосних

        foreach (var word in words) // Перебір кожного слова
        {
            if (string.IsNullOrEmpty(word)) continue; // Пропуск порожніх слів
            int vowels = word.Count(c => "аеєиіїоуюяАЕЄИІЇОУЮЯ".Contains(c)); // Підрахунок голосних літер
            int consonants = word.Count(c => "бвгґджзйклмнпрстфхцчшщБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩ".Contains(c)); // Підрахунок приголосних літер
            if (vowels == consonants) // Перевірка, чи рівна кількість голосних і приголосних
            {
                count++; // Збільшення лічильника
                equalWords.Add(word); // Додавання слова до списку
            }
        }
        return (count, equalWords); // Повернення кількості слів та списку слів
    }

    static string FindLongestWord(string input)
    {
        string[] words = Regex.Split(input, @"\W+"); // Розбиття рядка на слова за допомогою регулярного виразу
        return words.OrderByDescending(w => w.Length).FirstOrDefault(); // Пошук найдовшого слова
    }

    static string RemovePalindromes(string input)
    {
        string[] words = Regex.Split(input, @"(\W+)"); // Розбиття рядка на слова та розділові знаки
        var resultWords = words.Where(word => !IsPalindrome(word) || Regex.IsMatch(word, @"\W")); // Видалення паліндромів, залишаючи розділові знаки
        return string.Join("", resultWords); // Об'єднання слів у рядок
    }

    static bool IsPalindrome(string word)
    {
        if (word.Length < 2) return false; // Короткі слова не є паліндромами
        string cleanedWord = new string(word.Where(char.IsLetter).ToArray()).ToLower(); // Видалення не літер та перетворення в нижній регістр
        string reversed = new string(cleanedWord.Reverse().ToArray()); // Реверс слова
        return cleanedWord.Equals(reversed, StringComparison.OrdinalIgnoreCase); // Перевірка, чи є слово паліндромом
    }
}

