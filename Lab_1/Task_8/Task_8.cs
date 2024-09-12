using System; // Підключення простору імен System

class Task8 // Оголошення класу
{
    static void Main() // Основний метод
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Введення даних
        Console.Write("Введіть похибку: "); // Запит похибки
        double eps = Convert.ToDouble(Console.ReadLine()); // Зчитування похибки
        Console.Write("Введіть кількість членів ряду: "); // Запит кількості членів
        int maxTerms = Convert.ToInt32(Console.ReadLine()); // Зчитування кількості членів

        double sum = 0; // Сума членів ряду
        double term; // Поточний член ряду
        double sumFirst10 = 0; // Сума перших 10 членів

        long k2 = 1; // Значення pow(2,n)
        short k1 = 1; // Значення pow(-1,n)

        bool epsReached = false; // Флаг для перевірки досягнення похибки

        for (long n = 0; n < maxTerms; n++, k2 *= 2, k1 = (short)-k1) // Обчислення членів ряду
        {
            term = k1 * (1.0 / (n * n + k2)); // Обчислення поточного члена
            sum += term; // Додавання до суми

            if (Math.Abs(term) < eps) // Перевірка точності
            {
                epsReached = true; // Встановлення флагу досягнення похибки
                break; // Вихід з циклу
            }

            if (n < 10) // Перевірка перших 10 членів
            {
                sumFirst10 += term; // Додавання до суми перших 10 членів
            }
        }

        if (epsReached)
        {
            Console.WriteLine("Досягнута задана похибка."); // Повідомлення про похибку
        }
        else
        {
            Console.WriteLine("Досягнуто максимальну кількість членів ряду."); // Повідомлення про досягнення максимальної кількості членів
        }

        Console.WriteLine("Сума перших 10 членів ряду = {0:F7}", sumFirst10); // Виведення суми перших 10 членів
        Console.WriteLine("Повна сума ряду = {0:F7}", sum); // Виведення загальної суми

        Console.ReadLine(); // Затримка перед закриттям програми
    }
}

