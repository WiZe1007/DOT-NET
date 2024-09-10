using System;  // Підключення базових класів.

class Task5  // Оголошення класу.
{
    static void Main()  // Головний метод.
    {
        double x, y;  // Змінні для координат.

        try  // Обробка помилок.
        {
            // Введення координат
            Console.Write("Введіть координату x > ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть координату y > ");
            y = Convert.ToDouble(Console.ReadLine());

            // Виведення значень
            Console.WriteLine($"x={x:0.000}; y={y:0.000}");

            // Перевірка умови
            if ((y >= 1 - x) && (x * x + y * y <= 1))   // Перевірка двох умов: точка повинна бути в межах лінії y >= 1 - x і в межах кола радіусом 1.
            {
                Console.WriteLine("Точка в межах області"); 
            }
            else
            {
                Console.WriteLine("Точка не в межах області");
            }
        }
        catch (FormatException)  // Помилка формату.
        {
            Console.WriteLine("Помилка: введено не число.");
        }
        catch (Exception ex)  // Інші помилки.
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}

