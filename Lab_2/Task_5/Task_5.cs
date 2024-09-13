using System;  // Підключення простору імен System

class Task_5  // Оголошення класу Task_5
{
    static void Main()
    {
        // Встановлення кодування для введення та виведення в консоль
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int size = 9; // Розмір матриці
        int[,] matrix = new int[size, size]; // Оголошення двовимірного масиву
        Random rand = new Random(); // Створення об'єкта для генерації випадкових чисел

        // Заповнення матриці випадковими числами
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = rand.Next(0, 100); // Присвоєння випадкового числа від 0 до 99
            }
        }

        // Відображення верхньої половини на нижню
        for (int i = 0; i < size / 2; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[size - 1 - i, j] = matrix[i, j]; // Копіювання значень з верхньої половини в нижню
            }
        }

        // Виведення матриці
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t"); // Виведення значення елемента матриці з табуляцією
            }
            Console.WriteLine(); // Перехід на новий рядок після виведення кожного рядка матриці
        }

        Console.ReadKey(); // Очікування натискання клавіші перед завершенням програми
    }
}

