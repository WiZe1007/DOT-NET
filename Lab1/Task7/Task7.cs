using System; // Підключення базових типів

class Task7
{
    static void Main()
    {
        long n = 0; // Індекс ряду
        double sum = 0; // Сума всіх членів
        double term; // Поточний член
        const double eps = 0.000001; // Точність
        long k2 = 1; // 2^n
        short k1 = 1; // (-1)^n
        double sumFirst10 = 0; // Сума перших 10 членів

        for (n = 0; ; n++, k2 *= 2, k1 = (short)-k1)
        {
            term = k1 * (1.0 / (n * n + k2)); // Обчислення члена
            if (Math.Abs(term) >= eps)
            {
                sum += term; // Додавання до суми
            }
            else
            {
                break; // Вихід з циклу
            }
            if (n < 10)
            {
                sumFirst10 += term; // Сума перших 10 членів
            }
        }

        Console.WriteLine("Сума 10-ти членів ряду = {0:F7}", sumFirst10); // Виведення суми 10 членів
        Console.WriteLine("Повна сума ряду = {0:F7}", sum); // Виведення повної суми
    }
}

