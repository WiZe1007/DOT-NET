using System; // Підключення простору імен System
using System.Linq; // Підключення простору імен System.Linq для використання LINQ
using System.Text.RegularExpressions; // Підключення простору імен для регулярних виразів

class Task_6 // Оголошення класу Task_6
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Console.WriteLine("Введіть текстовий рядок:"); // Виведення запиту на введення тексту
        string input = Console.ReadLine(); // Зчитування введеного тексту

        // Завдання а)
        int countEqualVowelsConsonants = CountWordsWithEqualVowelsAndConsonants(input); // Виклик методу для підрахунку слів з однаковою кількістю голосних і приголосних
        Console.WriteLine($"Кількість слів з однаковою кількістю голосних і приголосних літер: {countEqualVowelsConsonants}"); // Виведення результату

        // Завдання б)
        string longestWord = FindLongestWord(input); // Виклик методу для знаходження найдовшого слова
        Console.WriteLine($"Найдовше слово: {longestWord}"); // Виведення результату

        // Завдання в)
        string resultWithoutPalindromes = RemovePalindromes(input); // Виклик методу для видалення паліндромів
        Console.WriteLine($"Текст без слів-паліндромів: {resultWithoutPalindromes}"); // Виведення результату

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static int CountWordsWithEqualVowelsAndConsonants(string input) // Метод для підрахунку слів з однаковою кількістю голосних і приголосних
    {
        string[] words = Regex.Split(input, @"\W+"); // Розбиття тексту на слова за допомогою регулярного виразу
        int count = 0; // Лічильник слів
        foreach (var word in words) // Перебір кожного слова
        {
            if (string.IsNullOrEmpty(word)) continue; // Пропуск порожніх слів
            int vowels = word.Count(c => "аеєиіїоуюяАЕЄИІЇОУЮЯ".Contains(c)); // Підрахунок голосних у слові
            int consonants = word.Count(c => "бвгґджзйклмнпрстфхцчшщБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩ".Contains(c)); // Підрахунок приголосних у слові
            if (vowels == consonants) // Перевірка, чи рівна кількість голосних і приголосних
            {
                count++; // Збільшення лічильника
            }
        }
        return count; // Повернення кількості слів
    }

    static string FindLongestWord(string input) // Метод для знаходження найдовшого слова
    {
        string[] words = Regex.Split(input, @"\W+"); // Розбиття тексту на слова за допомогою регулярного виразу
        return words.OrderByDescending(w => w.Length).FirstOrDefault(); // Повернення найдовшого слова
    }

    static string RemovePalindromes(string input) // Метод для видалення паліндромів
    {
        string[] words = Regex.Split(input, @"(\W+)"); // Розбиття тексту на слова та розділові знаки
        var resultWords = words.Where(word => !IsPalindrome(word) || Regex.IsMatch(word, @"\W")); // Фільтрація слів, які не є паліндромами
        return string.Join("", resultWords); // Об'єднання слів у рядок
    }

    static bool IsPalindrome(string word) // Метод для перевірки, чи є слово паліндромом
    {
        if (word.Length < 2) return false; // Короткі слова не є паліндромами
        string cleanedWord = new string(word.Where(char.IsLetter).ToArray()).ToLower(); // Видалення не літерних символів і перетворення в нижній регістр
        string reversed = new string(cleanedWord.Reverse().ToArray()); // Реверс слова
        return cleanedWord.Equals(reversed, StringComparison.OrdinalIgnoreCase); // Перевірка, чи рівне слово своєму реверсу
    }
}

