using System; // Підключення простору імен System

class Task_9 // Оголошення класу Task_9
{
    static void Main() // Головний метод програми
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        int[,] matrix = { // Оголошення та ініціалізація двовимірного масиву
            { 1, 3, 5, 7 },
            { 2, 4, 6, 8 },
            { 1, 2, 3, 4 },
            { 10, 20, 30, 40 }
        };

        int rowCount = matrix.GetLength(0); // Отримання кількості рядків у матриці
        int colCount = matrix.GetLength(1); // Отримання кількості стовпців у матриці
        int arithmeticRowsCount = 0; // Лічильник рядків, що утворюють арифметичну прогресію

        Console.WriteLine("Матриця:"); // Виведення заголовку для матриці
        for (int i = 0; i < rowCount; i++) // Цикл по рядках матриці
        {
            for (int j = 0; j < colCount; j++) // Цикл по стовпцях матриці
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // Встановлення кольору тексту
                Console.Write(matrix[i, j] + "\t"); // Виведення елемента матриці з табуляцією
            }
            Console.WriteLine(); // Перехід на новий рядок після виведення всіх елементів рядка
        }

        Console.ResetColor(); // Скидання кольору тексту до стандартного

        for (int i = 0; i < rowCount; i++) // Цикл по рядках матриці для перевірки арифметичної прогресії
        {
            if (IsArithmeticProgression(matrix, i, colCount)) // Перевірка, чи утворює рядок арифметичну прогресію
            {
                arithmeticRowsCount++; // Збільшення лічильника, якщо рядок утворює арифметичну прогресію
            }
        }

        Console.ForegroundColor = ConsoleColor.Green; // Встановлення кольору тексту
        Console.WriteLine($"\nКількість рядків, елементи яких утворюють арифметичну прогресію: {arithmeticRowsCount}"); // Виведення результату
        Console.ResetColor(); // Скидання кольору тексту до стандартного

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }

    static bool IsArithmeticProgression(int[,] matrix, int row, int colCount) // Метод для перевірки, чи утворює рядок арифметичну прогресію
    {
        if (colCount < 2) return false; // Якщо кількість стовпців менше 2, повернути false

        int difference = matrix[row, 1] - matrix[row, 0]; // Обчислення різниці між першим і другим елементами рядка

        for (int j = 1; j < colCount; j++) // Цикл по елементах рядка
        {
            if (matrix[row, j] - matrix[row, j - 1] != difference) // Якщо різниця між сусідніми елементами не дорівнює початковій різниці
            {
                return false; // Повернути false, якщо рядок не утворює арифметичну прогресію
            }
        }

        return true; // Повернути true, якщо рядок утворює арифметичну прогресію
    }
}

