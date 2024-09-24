using System;                              // Підключає базову бібліотеку для введення/виведення.
using System.Collections.Generic;          // Додає можливість використовувати списки (List) та інші колекції.

public class Student                       // Оголошення класу Student, що представляє студента.
{
    public string Name { get; set; }       // Властивість для зберігання імені студента.
    public int ID { get; set; }            // Властивість для зберігання ID студента.

    public Student(string name, int id)    // Конструктор для ініціалізації імені та ID.
    {
        Name = name;                       // Присвоєння переданого значення імені.
        ID = id;                           // Присвоєння переданого значення ID.
    }

    public void Show()                     // Метод для виведення інформації про студента.
    {
        Console.WriteLine($"Студент: {Name}, ID: {ID}"); // Виведення імені та ID студента.
    }
}

public class Faculty                       // Оголошення класу Faculty, що представляє факультет.
{
    public string FacultyName { get; set; } // Властивість для зберігання назви факультету.
    private List<Student> students;        // Приватний список студентів на факультеті.

    public Faculty(string facultyName)     // Конструктор для ініціалізації назви факультету.
    {
        FacultyName = facultyName;         // Присвоєння назви факультету.
        students = new List<Student>();    // Створення порожнього списку студентів.
    }

    public void AddStudent(Student student) // Метод для додавання студента до факультету.
    {
        students.Add(student);             // Додає студента в список.
        Console.WriteLine($"Додано студента: {student.Name} на факультет {FacultyName}"); // Виведення повідомлення про додавання студента.
    }

    public void RemoveStudent(Student student) // Метод для видалення студента з факультету.
    {
        if (students.Remove(student))       // Якщо видалення студента пройшло успішно.
        {
            Console.WriteLine($"Видалено студента: {student.Name} з факультету {FacultyName}"); // Повідомлення про видалення студента.
        }
        else                               // Якщо студента не знайдено в списку.
        {
            Console.WriteLine($"Студент {student.Name} не знайдено на факультеті {FacultyName}"); // Повідомлення про помилку.
        }
    }

    public void ChangeStudentName(int id, string newName) // Метод для зміни імені студента за ID.
    {
        var student = students.Find(s => s.ID == id); // Пошук студента за його ID.
        if (student != null)                          // Якщо студент знайдений.
        {
            student.Name = newName;                   // Зміна імені студента.
            Console.WriteLine($"Змінено ім'я студента з ID {id} на {newName}"); // Повідомлення про зміну імені.
        }
        else                                          // Якщо студента не знайдено.
        {
            Console.WriteLine($"Студента з ID {id} не знайдено."); // Повідомлення про помилку.
        }
    }

    public void ShowStudents()             // Метод для виведення списку студентів на факультеті.
    {
        Console.WriteLine($"Студенти факультету {FacultyName}:"); // Виведення назви факультету.
        foreach (var student in students)  // Перебір кожного студента у списку.
        {
            student.Show();                // Виведення інформації про студента.
        }
    }
}

public class Task_4_1                      // Оголошення класу Task_4_1 для основної програми.
{
    public static void Main()              // Головна функція програми.
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;  // Налаштування кодування для введення.
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Налаштування кодування для виведення.

        Faculty faculty = new Faculty("Комп'ютерні науки"); // Створення об'єкта факультету.

        // Додавання студентів
        Student student1 = new Student("Олег", 101);        // Створення першого студента.
        Student student2 = new Student("Ірина", 102);       // Створення другого студента.
        Student student3 = new Student("Сергій", 103);      // Створення третього студента.

        faculty.AddStudent(student1);                       // Додавання першого студента на факультет.
        faculty.AddStudent(student2);                       // Додавання другого студента на факультет.
        faculty.AddStudent(student3);                       // Додавання третього студента на факультет.

        // Показати всіх студентів
        faculty.ShowStudents();                             // Виведення списку студентів на факультеті.

        // Змінити ім'я студента
        faculty.ChangeStudentName(102, "Ірина Петрівна");   // Зміна імені другого студента.

        // Видалення студента
        faculty.RemoveStudent(student2);                    // Видалення другого студента.

        // Показати всіх студентів після видалення
        faculty.ShowStudents();                             // Виведення списку студентів після видалення.

        Console.ReadKey();                                  // Очікування натискання клавіші для завершення програми.
    }
}

