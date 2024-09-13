using System; // Підключення простору імен System

class Task_8 // Оголошення класу Task_8
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування вводу UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування виводу UTF-8

        Console.Write("Введіть розмір матриці: "); // Запит розміру матриці у користувача
        int size = int.Parse(Console.ReadLine()); // Зчитування розміру матриці з консолі

        int[][] matrix = new int[size][]; // Оголошення зубчастого масиву
        Random rand = new Random(); // Створення об'єкта для генерації випадкових чисел

        // Ініціалізація зубчастого масиву
        for (int i = 0; i < size; i++)
        {
            matrix[i] = new int[size]; // Ініціалізація кожного рядка масиву
        }

        // Заповнення матриці випадковими числами
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i][j] = rand.Next(0, 100); // Заповнення елементів матриці випадковими числами від 0 до 99
            }
        }

        // Відображення верхньої половини на нижню
        for (int i = 0; i < size / 2; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[size - 1 - i][j] = matrix[i][j]; // Копіювання верхньої половини матриці на нижню
            }
        }

        // Виведення матриці з кольорами
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i < size / 2)
                {
                    // Верхня половина матриці
                    Console.ForegroundColor = ConsoleColor.Green; // Встановлення зеленого кольору для верхньої половини
                }
                else if (i >= size / 2)
                {
                    // Нижня половина матриці
                    Console.ForegroundColor = ConsoleColor.Yellow; // Встановлення жовтого кольору для нижньої половини
                }
                Console.Write(matrix[i][j] + "\t"); // Виведення елемента матриці з табуляцією
            }
            Console.WriteLine(); // Перехід на новий рядок після виведення кожного рядка матриці
            Console.ResetColor(); // Скидання кольору до стандартного
        }

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }
}

