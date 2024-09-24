using System; // Підключення базової бібліотеки для введення-виведення та інших функцій.
using System.Collections.Generic; // Підключення бібліотеки для роботи зі списками та іншими колекціями.
using System.Linq; // Підключення бібліотеки для LINQ-запитів.

public class Word // Оголошення класу "Word", що описує слово та його властивості.
{
    public string Text { get; set; } // Властивість для зберігання тексту слова.
    public List<int> PageNumbers { get; set; } // Властивість для зберігання номерів сторінок.
    public int TotalPages { get; set; } // Властивість для зберігання загальної кількості сторінок.

    public Word(string text, List<int> pageNumbers, int totalPages) // Конструктор для ініціалізації властивостей.
    {
        Text = text; // Ініціалізація тексту слова.
        PageNumbers = pageNumbers; // Ініціалізація номерів сторінок.
        TotalPages = totalPages; // Ініціалізація загальної кількості сторінок.
    }

    public void Show() // Метод для виведення інформації про слово.
    {
        Console.WriteLine($"Слово: {Text}, Номери сторінок: {string.Join(", ", PageNumbers)}, Число сторінок: {TotalPages}"); // Виведення у форматі: слово, номери сторінок, кількість сторінок.
    }

    public bool AppearsOnMoreThanNPages(int n) // Метод, що перевіряє, чи слово зустрічається більше ніж на n сторінках.
    {
        return PageNumbers.Count > n; // Повертає true, якщо кількість сторінок більше n.
    }

    public static void ShowWordsAlphabetically(List<Word> words) // Статичний метод для виведення слів за абеткою.
    {
        var sortedWords = words.OrderBy(w => w.Text).ToList(); // Сортування слів за текстом.
        foreach (var word in sortedWords) // Перебір відсортованих слів.
        {
            word.Show(); // Виклик методу Show для кожного слова.
        }
    }

    public static void ShowPagesForWord(List<Word> words, string searchWord) // Статичний метод для пошуку слова та виведення його сторінок.
    {
        var word = words.FirstOrDefault(w => w.Text.Equals(searchWord, StringComparison.OrdinalIgnoreCase)); // Пошук слова без урахування регістру.
        if (word != null) // Якщо слово знайдено.
        {
            Console.WriteLine($"Слово '{searchWord}' зустрічається на сторінках: {string.Join(", ", word.PageNumbers)}"); // Виведення номерів сторінок.
        }
        else // Якщо слово не знайдено.
        {
            Console.WriteLine($"Слово '{searchWord}' не знайдено."); // Повідомлення про відсутність слова.
        }
    }
}

public class Task_1 // Головний клас для виконання задачі.
{
    public static void Main() // Головний метод, який виконується при запуску програми.
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для введення UTF-8.
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виведення UTF-8.

        Random random = new Random(); // Створення об'єкта для генерації випадкових чисел.
        List<Word> words = new List<Word>(); // Створення списку слів.

        // Українські слова
        string[] ukrainianWords = { "Книга", "Слово", "Мова", "Україна", "Програмування", "Комп'ютер", "Інтернет", "Освіта", "Наука", "Технології" }; // Масив українських слів.

        // Генерація випадкових даних
        for (int i = 0; i < ukrainianWords.Length; i++) // Цикл по всіх українських словах.
        {
            string text = ukrainianWords[i]; // Отримання тексту слова.
            List<int> pageNumbers = Enumerable.Range(1, 10).OrderBy(x => random.Next()).Take(random.Next(1, 11)).ToList(); // Генерація випадкових номерів сторінок.
            int totalPages = random.Next(1, 11); // Генерація випадкової кількості сторінок.
            words.Add(new Word(text, pageNumbers, totalPages)); // Додавання слова до списку.
        }

        // Виведення всіх слів
        Console.WriteLine("Всі слова:"); // Заголовок.
        foreach (var word in words) // Цикл по всіх словах.
        {
            word.Show(); // Виведення кожного слова.
        }

        // Виведення слів, що зустрічаються більш ніж на N сторінках
        int N = 3; // Задане число N.
        Console.WriteLine($"\nСлова, що зустрічаються більш ніж на {N} сторінках:"); // Заголовок.
        foreach (var word in words.Where(w => w.AppearsOnMoreThanNPages(N))) // Перебір слів, що зустрічаються більше ніж на N сторінках.
        {
            word.Show(); // Виведення таких слів.
        }

        // Виведення слів за абеткою
        Console.WriteLine("\nСлова за абеткою:"); // Заголовок.
        Word.ShowWordsAlphabetically(words); // Виклик статичного методу для виведення слів за абеткою.

        // Виведення сторінок для заданого слова
        string searchWord = "Програмування"; // Задане слово для пошуку.
        Console.WriteLine($"\nНомери сторінок для слова '{searchWord}':"); // Заголовок.
        Word.ShowPagesForWord(words, searchWord); // Виклик статичного методу для виведення сторінок для заданого слова.

        // Додавання нового слова
        string newText = "Новинка"; // Текст нового слова.
        List<int> newPageNumbers = new List<int> { 1, 2, 3 }; // Номери сторінок для нового слова.
        int newTotalPages = 3; // Кількість сторінок для нового слова.
        words.Add(new Word(newText, newPageNumbers, newTotalPages)); // Додавання нового слова до списку.
        Console.WriteLine("\nДодано нове слово:"); // Повідомлення про додавання нового слова.
        words.Last().Show(); // Виведення нового слова.

        // Редагування слова
        string editWord = "Книга"; // Слово для редагування.
        var wordToEdit = words.FirstOrDefault(w => w.Text == editWord); // Пошук слова для редагування.
        if (wordToEdit != null) // Якщо слово знайдено.
        {
            wordToEdit.PageNumbers = new List<int> { 4, 5, 6 }; // Зміна номерів сторінок.
            wordToEdit.TotalPages = 3; // Зміна кількості сторінок.
            Console.WriteLine($"\nВідредаговано слово '{editWord}':"); // Повідомлення про редагування.
            wordToEdit.Show(); // Виведення відредагованого слова.
        }

        // Видалення слова
        string deleteWord = "Слово"; // Слово для видалення.
        var wordToDelete = words.FirstOrDefault(w => w.Text == deleteWord); // Пошук слова для видалення.
        if (wordToDelete != null) // Якщо слово знайдено.
        {
            words.Remove(wordToDelete); // Видалення слова зі списку.
            Console.WriteLine($"\nВидалено слово '{deleteWord}'."); // Повідомлення про видалення.
        }

        // Виведення всіх слів після редагування та видалення
        Console.WriteLine("\nВсі слова після редагування та видалення:"); // Заголовок.
        foreach (var word in words) // Перебір всіх слів після змін.
        {
            word.Show(); // Виведення кожного слова.
        }

        Console.ReadKey(); // Очікування натискання клавіші для завершення програми.
    }
}

