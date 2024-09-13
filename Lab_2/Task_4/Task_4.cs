using System; // Підключення простору імен System
using System.Collections.Generic; // Підключення простору імен для роботи з колекціями

class Task_4 // Оголошення класу Task_4
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для введення
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виведення

        Console.Write("Введіть розмір масиву: "); // Запит розміру масиву у користувача
        int size = int.Parse(Console.ReadLine()); // Зчитування розміру масиву з консолі

        List<int> list = new List<int>(); // Створення списку цілих чисел
        Random rand = new Random(); // Створення об'єкта для генерації випадкових чисел

        // Заповнення списку випадковими значеннями від -100 до 100
        for (int i = 0; i < size; i++)
        {
            list.Add(rand.Next(-100, 101)); // Додавання випадкового числа до списку
        }

        Console.WriteLine("Початковий список:"); // Виведення початкового списку
        PrintList(list); // Виклик методу для виведення списку

        // Обробка списку
        ProcessList(list); // Виклик методу для обробки списку

        Console.WriteLine("\nСписок після обробки:"); // Виведення списку після обробки
        PrintList(list); // Виклик методу для виведення списку

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static void ProcessList(List<int> list) // Метод для обробки списку
    {
        int start = -1; // Початковий індекс послідовності невід'ємних чисел
        int end = -1; // Кінцевий індекс послідовності невід'ємних чисел
        int sum = 0; // Сума невід'ємних чисел у послідовності
        int count = 0; // Кількість невід'ємних чисел у послідовності

        for (int i = 0; i < list.Count; i++) // Проходження по всіх елементах списку
        {
            if (list[i] >= 0) // Якщо елемент невід'ємний
            {
                if (start == -1) // Якщо це початок нової послідовності
                {
                    start = i; // Встановлення початкового індексу
                }
                end = i; // Оновлення кінцевого індексу
                sum += list[i]; // Додавання елемента до суми
                count++; // Збільшення лічильника елементів
            }
            else // Якщо елемент від'ємний
            {
                if (count > 1) // Якщо в послідовності більше одного елемента
                {
                    int average = sum / count; // Обчислення середнього значення
                    int maxIndex = start; // Індекс максимального елемента
                    int minIndex = start; // Індекс мінімального елемента

                    for (int j = start; j <= end; j++) // Проходження по послідовності
                    {
                        if (list[j] > list[maxIndex]) // Якщо елемент більший за поточний максимум
                        {
                            maxIndex = j; // Оновлення індексу максимального елемента
                        }
                        if (list[j] < list[minIndex]) // Якщо елемент менший за поточний мінімум
                        {
                            minIndex = j; // Оновлення індексу мінімального елемента
                        }
                    }

                    HighlightList(list, start, end, maxIndex, minIndex, average); // Виклик методу для виділення послідовності

                    list[maxIndex] = average; // Замінити максимальний елемент на середнє значення
                    list[minIndex] = average; // Замінити мінімальний елемент на середнє значення
                }

                start = -1; // Скидання початкового індексу
                end = -1; // Скидання кінцевого індексу
                sum = 0; // Скидання суми
                count = 0; // Скидання лічильника
            }
        }

        // Обробка останньої послідовності, якщо вона існує
        if (count > 1)
        {
            int average = sum / count; // Обчислення середнього значення
            int maxIndex = start; // Індекс максимального елемента
            int minIndex = start; // Індекс мінімального елемента

            for (int j = start; j <= end; j++) // Проходження по послідовності
            {
                if (list[j] > list[maxIndex]) // Якщо елемент більший за поточний максимум
                {
                    maxIndex = j; // Оновлення індексу максимального елемента
                }
                if (list[j] < list[minIndex]) // Якщо елемент менший за поточний мінімум
                {
                    minIndex = j; // Оновлення індексу мінімального елемента
                }
            }

            HighlightList(list, start, end, maxIndex, minIndex, average); // Виклик методу для виділення послідовності

            list[maxIndex] = average; // Замінити максимальний елемент на середнє значення
            list[minIndex] = average; // Замінити мінімальний елемент на середнє значення
        }
    }

    static void HighlightList(List<int> list, int start, int end, int maxIndex, int minIndex, int average) // Метод для виділення послідовності
    {
        Console.WriteLine("\nОбробка послідовності:"); // Виведення повідомлення про обробку
        for (int i = start; i <= end; i++) // Проходження по послідовності
        {
            if (i == maxIndex || i == minIndex) // Якщо елемент є максимальним або мінімальним
            {
                Console.ForegroundColor = ConsoleColor.Red; // Встановлення червоного кольору для виведення
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; // Встановлення зеленого кольору для виведення
            }
            Console.Write(list[i] + " "); // Виведення елемента
        }
        Console.ResetColor(); // Скидання кольору
        Console.ForegroundColor = ConsoleColor.Yellow; // Встановлення жовтого кольору для виведення
        Console.WriteLine($"\nСереднє значення: {average}"); // Виведення середнього значення
        Console.ResetColor(); // Скидання кольору
    }

    static void PrintList(List<int> list) // Метод для виведення списку
    {
        foreach (int value in list) // Проходження по всіх елементах списку
        {
            Console.Write(value + " "); // Виведення елемента
        }
        Console.WriteLine(); // Перехід на новий рядок
    }
}

