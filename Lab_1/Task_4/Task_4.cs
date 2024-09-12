using System;

class Task4
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            // Введення значень x і y з клавіатури
            Console.Write("Введіть x: ");
            double x = Convert.ToDouble(Console.ReadLine()); // Читання значення x з клавіатури і перетворення його на тип double
            Console.Write("Введіть y: ");
            double y = Convert.ToDouble(Console.ReadLine()); // Читання значення y з клавіатури і перетворення його на тип double

            // Початкові значення змінних
            double a = 12.5, b = 1.3; // Ініціалізація змінних a і b значеннями 12.5 і 1.3 відповідно

            // Перевірка на некоректні значення
            if (x == 0 || y == 0) // Перевіряє, чи не дорівнюють x або y нулю
            {
                throw new ArgumentException("Значення x і y не можуть бути нульовими."); // Викидання помилки, якщо x або y дорівнює нулю
            }

            // Обчислення t1
            double t1 = (1 / Math.Pow(b, 3)) * (Math.Pow(a, 2) * Math.Log(y / x) + (2 * a * x / y) + (Math.Pow(y, 2) / (2 * Math.Pow(x, 2))));
            // Обчислює значення t1 за допомогою заданої формули

            // Обчислення t2
            double ax = a * x; // Обчислює значення ax як добуток a і x
            if (Math.Sin(ax) == 0) // Перевіряє, чи не дорівнює sin(ax) нулю
            {
                throw new ArgumentException("Значення ax не може бути таким, щоб sin(ax) дорівнював нулю."); // Викидає помилку, якщо sin(ax) дорівнює нулю
            }
            double t2 = (1 / (2 * Math.Sqrt(2) * a)) + ((3 * Math.Pow(Math.Sin(ax), 2) - 1) / (Math.Pow(Math.Sin(ax), 2) - 1));
            // Обчислює значення t2 за іншою формулою

            // Виведення результатів
            Console.WriteLine($"t1 = {t1}"); // Виводить значення t1
            Console.WriteLine($"t2 = {t2}"); // Виводить значення t2
        }
        catch (ArgumentException ex) // Ловить помилки, пов'язані з некоректними аргументами
        {
            Console.WriteLine($"Помилка: {ex.Message}"); // Виводить повідомлення про помилку
        }
        catch (Exception ex) // Ловить інші непередбачені помилки
        {
            Console.WriteLine($"Непередбачена помилка: {ex.Message}"); // Виводить повідомлення про непередбачену помилку
        }
        finally
        {
            Console.WriteLine("Програма завершила виконання."); // Повідомлення про завершення роботи програми
        }

        Console.ReadLine(); // Затримка перед закриттям програми
    }
}

