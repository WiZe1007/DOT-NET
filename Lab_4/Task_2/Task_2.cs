using System; // Підключення базової бібліотеки для роботи з консоллю та іншими системними функціями
using System.Collections.Generic; // Підключення бібліотеки для роботи з колекціями (списками)
using System.Linq; // Підключення бібліотеки для зручних запитів до колекцій

// Завдання 1: Створення абстрактного класу TextItem
public abstract class TextItem
{
    public string Text { get; set; } // Властивість для збереження тексту
    public List<int> PageNumbers { get; set; } // Властивість для збереження списку номерів сторінок
    public int TotalPages { get; set; } // Властивість для збереження загальної кількості сторінок

    // Конструктор класу TextItem
    public TextItem(string text, List<int> pageNumbers, int totalPages)
    {
        Text = text; // Ініціалізація тексту
        PageNumbers = pageNumbers; // Ініціалізація номерів сторінок
        TotalPages = totalPages; // Ініціалізація загальної кількості сторінок
    }

    // Абстрактний метод Show, який мають реалізувати спадкоємці
    public abstract void Show();
}

// Завдання 2: Додавання класів-спадкоємців першого рівня
public class WordItem : TextItem
{
    // Конструктор класу WordItem
    public WordItem(string text, List<int> pageNumbers, int totalPages)
        : base(text, pageNumbers, totalPages) // Виклик конструктора базового класу
    {
    }

    // Перевизначений метод Show для відображення інформації про слово
    public override void Show()
    {
        Console.WriteLine($"Слово: {Text}, Номери сторінок: {string.Join(", ", PageNumbers)}, Число сторінок: {TotalPages}");
    }

    // Метод для перевірки, чи зустрічається слово більш ніж на n сторінках
    public bool AppearsOnMoreThanNPages(int n)
    {
        return PageNumbers.Count > n;
    }
}

public class SentenceItem : TextItem
{
    // Конструктор класу SentenceItem
    public SentenceItem(string text, List<int> pageNumbers, int totalPages)
        : base(text, pageNumbers, totalPages) // Виклик конструктора базового класу
    {
    }

    // Перевизначений метод Show для відображення інформації про речення
    public override void Show()
    {
        Console.WriteLine($"Речення: {Text}, Номери сторінок: {string.Join(", ", PageNumbers)}, Число сторінок: {TotalPages}");
    }
}

public class ParagraphItem : TextItem
{
    // Конструктор класу ParagraphItem
    public ParagraphItem(string text, List<int> pageNumbers, int totalPages)
        : base(text, pageNumbers, totalPages) // Виклик конструктора базового класу
    {
    }

    // Перевизначений метод Show для відображення інформації про параграф
    public override void Show()
    {
        Console.WriteLine($"Параграф: {Text}, Номери сторінок: {string.Join(", ", PageNumbers)}, Число сторінок: {TotalPages}");
    }
}

// Завдання 3: Додавання класів-спадкоємців другого рівня
public class TitleSentenceItem : SentenceItem
{
    public string Title { get; set; } // Властивість для збереження заголовку

    // Конструктор класу TitleSentenceItem
    public TitleSentenceItem(string text, List<int> pageNumbers, int totalPages, string title)
        : base(text, pageNumbers, totalPages) // Виклик конструктора базового класу SentenceItem
    {
        Title = title; // Ініціалізація заголовку
    }

    // Перевизначений метод Show для відображення заголовку та речення
    public override void Show()
    {
        Console.WriteLine($"Заголовок: {Title}, Речення: {Text}, Номери сторінок: {string.Join(", ", PageNumbers)}, Число сторінок: {TotalPages}");
    }
}

public class BodySentenceItem : SentenceItem
{
    public string Body { get; set; } // Властивість для збереження тіла тексту

    // Конструктор класу BodySentenceItem
    public BodySentenceItem(string text, List<int> pageNumbers, int totalPages, string body)
        : base(text, pageNumbers, totalPages) // Виклик конструктора базового класу SentenceItem
    {
        Body = body; // Ініціалізація тіла тексту
    }

    // Перевизначений метод Show для відображення тіла та речення
    public override void Show()
    {
        Console.WriteLine($"Тіло: {Body}, Речення: {Text}, Номери сторінок: {string.Join(", ", PageNumbers)}, Число сторінок: {TotalPages}");
    }
}

// Завдання 4: Створення масиву об'єктів та виконання функцій над поліморфним списком
public class Task_2
{
    public static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        Random random = new Random(); // Створення об'єкта для генерації випадкових чисел
        List<TextItem> textItems = new List<TextItem>(); // Створення списку текстових елементів

        // Українські слова
        string[] ukrainianWords = { "Книга", "Слово", "Мова", "Україна", "Програмування", "Комп'ютер", "Інтернет", "Освіта", "Наука", "Технології" };

        // Генерація випадкових даних для класів першого рівня
        for (int i = 0; i < ukrainianWords.Length; i++)
        {
            string text = ukrainianWords[i]; // Вибір слова
            List<int> pageNumbers = Enumerable.Range(1, 10).OrderBy(x => random.Next()).Take(random.Next(1, 11)).ToList(); // Генерація випадкових номерів сторінок
            int totalPages = random.Next(1, 11); // Випадкова кількість сторінок
            textItems.Add(new WordItem(text, pageNumbers, totalPages)); // Додавання слова в список
        }

        // Генерація випадкових даних для класів другого рівня
        textItems.Add(new TitleSentenceItem("Заголовок 1", new List<int> { 1, 2, 3 }, 3, "Заголовок")); // Додавання заголовка
        textItems.Add(new BodySentenceItem("Тіло 1", new List<int> { 4, 5, 6 }, 3, "Тіло")); // Додавання тіла тексту

        // Виведення всіх текстових елементів
        Console.WriteLine("Всі текстові елементи:");
        foreach (var item in textItems) // Перебір кожного елемента в списку
        {
            item.Show(); // Виклик методу Show для кожного елемента
        }

        // Виведення слів, що зустрічаються більш ніж на N сторінках
        int N = 3; // Встановлення порогу для кількості сторінок
        Console.WriteLine($"\nСлова, що зустрічаються більш ніж на {N} сторінках:");
        foreach (var item in textItems.OfType<WordItem>().Where(w => w.AppearsOnMoreThanNPages(N))) // Фільтрація слів, що зустрічаються більше ніж на N сторінках
        {
            item.Show(); // Виведення цих слів
        }

        // Виведення слів за абеткою
        Console.WriteLine("\nСлова за абеткою:");
        var sortedWords = textItems.OfType<WordItem>().OrderBy(w => w.Text).ToList(); // Сортування слів за алфавітом
        foreach (var word in sortedWords) // Перебір кожного слова
        {
            word.Show(); // Виведення слова
        }

        // Виведення сторінок для заданого слова
        string searchWord = "Програмування"; // Слово для пошуку
        Console.WriteLine($"\nНомери сторінок для слова '{searchWord}':");
        var wordToShow = textItems.OfType<WordItem>().FirstOrDefault(w => w.Text.Equals(searchWord, StringComparison.OrdinalIgnoreCase)); // Пошук слова у списку
        if (wordToShow != null) // Якщо слово знайдено
        {
            wordToShow.Show(); // Виведення інформації про слово
        }
        else
        {
            Console.WriteLine($"Слово '{searchWord}' не знайдено."); // Якщо слово не знайдено
        }

        Console.ReadKey(); // Очікування натискання клавіші для завершення програми
    }
}

