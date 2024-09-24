using System; // Підключає простір імен для базових функцій, як Console.
using System.Collections.Generic; // Підключає простір імен для роботи зі списками (List).
using System.Linq; // Дозволяє використовувати LINQ-запити для колекцій, наприклад FirstOrDefault.

public class Grade // Оголошуємо клас Grade для збереження інформації про предмет і оцінку.
{
    public string Subject { get; set; } // Властивість для збереження назви предмету.
    public int Score { get; set; } // Властивість для збереження оцінки.

    public Grade(string subject, int score) // Конструктор класу Grade.
    {
        Subject = subject; // Ініціалізуємо властивість Subject значенням параметра.
        Score = score; // Ініціалізуємо властивість Score значенням параметра.
    }
}

public class Students // Оголошуємо клас Students для збереження інформації про студента і його оцінки.
{
    public string Name { get; set; } // Властивість для збереження імені студента.
    private List<Grade> grades; // Приватний список для зберігання оцінок студента.

    public Students(string name) // Конструктор класу Students.
    {
        Name = name; // Ініціалізуємо властивість Name значенням параметра.
        grades = new List<Grade>(); // Ініціалізуємо порожній список оцінок.
    }

    public void AddGrade(string subject, int score) // Метод для додавання оцінки.
    {
        grades.Add(new Grade(subject, score)); // Створюємо новий об'єкт Grade і додаємо його до списку.
        Console.WriteLine($"Додано оцінку для студента {Name}: {subject} - {score}"); // Виводимо повідомлення про додавання оцінки.
    }

    public void RemoveGrade(string subject) // Метод для видалення оцінки за назвою предмету.
    {
        var gradeToRemove = grades.FirstOrDefault(g => g.Subject.Equals(subject, StringComparison.OrdinalIgnoreCase)); // Шукаємо предмет у списку.
        if (gradeToRemove != null) // Якщо предмет знайдено.
        {
            grades.Remove(gradeToRemove); // Видаляємо оцінку.
            Console.WriteLine($"Видалено оцінку {subject} для студента {Name}"); // Повідомляємо про видалення.
        }
        else
        {
            Console.WriteLine($"Оцінка {subject} не знайдена для студента {Name}"); // Повідомляємо, що предмет не знайдено.
        }
    }

    public void ShowGrades() // Метод для виведення всіх оцінок студента.
    {
        Console.WriteLine($"Оцінки студента {Name}:"); // Заголовок для оцінок.
        foreach (var grade in grades) // Проходимо по кожній оцінці у списку.
        {
            Console.WriteLine($"Дисципліна: {grade.Subject}, Оцінка: {grade.Score}"); // Виводимо предмет і оцінку.
        }
    }
}

public class Task_4_2 // Основний клас для виконання програми.
{
    public static void Main() // Точка входу в програму.
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлюємо кодування UTF-8 для введення.
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлюємо кодування UTF-8 для виведення.

        Students studentOleg = new Students("Олег"); // Створюємо об'єкт студента Олега.
        Students studentIrina = new Students("Ірина"); // Створюємо об'єкт студента Ірини.

        // Додаємо оцінки для студентів.
        studentOleg.AddGrade("Математика", 95);
        studentOleg.AddGrade("Фізика", 89);
        studentIrina.AddGrade("Хімія", 92);
        studentIrina.AddGrade("Біологія", 85);

        // Виводимо оцінки студентів.
        studentOleg.ShowGrades();
        studentIrina.ShowGrades();

        // Видаляємо оцінку і знову виводимо оцінки для перевірки.
        studentOleg.RemoveGrade("Фізика");
        studentOleg.ShowGrades();

        // Додаємо нову оцінку для Ірини.
        studentIrina.AddGrade("Інформатика", 98);
        studentIrina.ShowGrades();

        Console.ReadKey(); // Чекаємо натискання клавіші для завершення програми.
    }
}

