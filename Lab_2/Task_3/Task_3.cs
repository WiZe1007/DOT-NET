using System; // Підключення простору імен System

class Task_3 // Оголошення класу Task_3
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для введення
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виведення

        Console.Write("Введіть розмір масиву: "); // Виведення запиту на введення розміру масиву
        int size = int.Parse(Console.ReadLine()); // Зчитування розміру масиву з консолі

        int[] array = new int[size]; // Оголошення масиву заданого розміру
        Random rand = new Random(); // Створення об'єкта для генерації випадкових чисел

        // Заповнення масиву випадковими значеннями від -100 до 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101); // Присвоєння випадкового значення елементу масиву
        }

        Console.WriteLine("Початковий масив:"); // Виведення повідомлення про початковий масив
        PrintArray(array); // Виклик методу для виведення масиву

        // Обробка масиву
        ProcessArray(array); // Виклик методу для обробки масиву

        Console.WriteLine("\nМасив після обробки:"); // Виведення повідомлення про оброблений масив
        PrintArray(array); // Виклик методу для виведення масиву

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static void ProcessArray(int[] array) // Метод для обробки масиву
    {
        int start = -1; // Початковий індекс послідовності невід'ємних чисел
        int end = -1; // Кінцевий індекс послідовності невід'ємних чисел
        int sum = 0; // Сума невід'ємних чисел у послідовності
        int count = 0; // Кількість невід'ємних чисел у послідовності

        for (int i = 0; i < array.Length; i++) // Прохід по всіх елементах масиву
        {
            if (array[i] >= 0) // Перевірка, чи є елемент невід'ємним
            {
                if (start == -1) // Якщо це початок нової послідовності
                {
                    start = i; // Встановлення початкового індексу
                }
                end = i; // Оновлення кінцевого індексу
                sum += array[i]; // Додавання елемента до суми
                count++; // Збільшення лічильника
            }
            else // Якщо елемент від'ємний
            {
                if (count > 1) // Якщо в послідовності більше одного елемента
                {
                    int average = sum / count; // Обчислення середнього значення
                    int maxIndex = start; // Індекс максимального елемента
                    int minIndex = start; // Індекс мінімального елемента

                    for (int j = start; j <= end; j++) // Прохід по послідовності
                    {
                        if (array[j] > array[maxIndex]) // Пошук максимального елемента
                        {
                            maxIndex = j;
                        }
                        if (array[j] < array[minIndex]) // Пошук мінімального елемента
                        {
                            minIndex = j;
                        }
                    }

                    HighlightArray(array, start, end, maxIndex, minIndex, average); // Виділення послідовності

                    array[maxIndex] = average; // Замінити максимальний елемент на середнє значення
                    array[minIndex] = average; // Замінити мінімальний елемент на середнє значення
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

            for (int j = start; j <= end; j++) // Прохід по послідовності
            {
                if (array[j] > array[maxIndex]) // Пошук максимального елемента
                {
                    maxIndex = j;
                }
                if (array[j] < array[minIndex]) // Пошук мінімального елемента
                {
                    minIndex = j;
                }
            }

            HighlightArray(array, start, end, maxIndex, minIndex, average); // Виділення послідовності

            array[maxIndex] = average; // Замінити максимальний елемент на середнє значення
            array[minIndex] = average; // Замінити мінімальний елемент на середнє значення
        }
    }

    static void HighlightArray(int[] array, int start, int end, int maxIndex, int minIndex, int average) // Метод для виділення послідовності
    {
        Console.WriteLine("\nОбробка послідовності:"); // Виведення повідомлення про обробку послідовності
        for (int i = start; i <= end; i++) // Прохід по послідовності
        {
            if (i == maxIndex || i == minIndex) // Якщо елемент є максимальним або мінімальним
            {
                Console.ForegroundColor = ConsoleColor.Red; // Встановлення червоного кольору для виведення
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; // Встановлення зеленого кольору для виведення
            }
            Console.Write(array[i] + " "); // Виведення елемента
        }
        Console.ResetColor(); // Скидання кольору
        Console.ForegroundColor = ConsoleColor.Yellow; // Встановлення жовтого кольору для виведення
        Console.WriteLine($"\nСереднє значення: {average}"); // Виведення середнього значення
        Console.ResetColor(); // Скидання кольору
    }

    static void PrintArray(int[] array) // Метод для виведення масиву
    {
        foreach (int value in array) // Прохід по всіх елементах масиву
        {
            Console.Write(value + " "); // Виведення елемента
        }
        Console.WriteLine(); // Перехід на новий рядок
    }
}

