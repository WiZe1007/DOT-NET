using System;  // Підключення бібліотеки System.

class Task6  // Оголошення класу Task6.
{
    static void Main()  // Головний метод.
    {
        double x, y;  // Оголошення змінних x і y.

        try  // Початок блоку обробки помилок.
        {
            Console.Write("Введіть координату x > ");  // Запит на введення x.
            x = Convert.ToDouble(Console.ReadLine());  // Читання та конвертація x.
            Console.Write("Введіть координату y > ");  // Запит на введення y.
            y = Convert.ToDouble(Console.ReadLine());  // Читання та конвертація y.

            Console.WriteLine($"x={x:0.000}; y={y:0.000}");  // Виведення x і y.

            string result = (y >= 1 - x) && (x * x + y * y <= 1)  // Перевірка умов.
                ? "Точка в межах області"  // Якщо умови істинні.
                : "Точка не в межах області";  // Якщо умови хибні.

            Console.WriteLine(result);  // Виведення результату.
        }
        catch (FormatException)  // Обробка помилок форматування.
        {
            Console.WriteLine("Помилка: введено некоректне значення.");  // Повідомлення про помилку.
        }
        catch (Exception ex)  // Обробка інших помилок.
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");  // Повідомлення про помилку.
        }
    }
}

