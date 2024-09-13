using System;  // Підключення простору імен System

class Task_6  // Оголошення класу Task_6
{
    static void Main()
    {
        // Встановлення кодування для введення та виведення в консоль
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Запит розміру матриці у користувача
        Console.Write("Введіть розмір матриці: ");
        int size = int.Parse(Console.ReadLine());

        // Створення двовимірного масиву для матриці
        int[,] matrix = new int[size, size];
        Random rand = new Random();

        // Заповнення матриці випадковими числами
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = rand.Next(0, 100); // Генерація випадкового числа від 0 до 99
            }
        }

        // Відображення верхньої половини матриці на нижню
        for (int i = 0; i < size / 2; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[size - 1 - i, j] = matrix[i, j]; // Копіювання значень з верхньої половини в нижню
            }
        }

        // Виведення матриці на екран
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t"); // Виведення елементів матриці з табуляцією
            }
            Console.WriteLine(); // Перехід на новий рядок після кожного рядка матриці
        }

        // Очікування натискання клавіші перед завершенням програми
        Console.ReadKey();
    }
}

