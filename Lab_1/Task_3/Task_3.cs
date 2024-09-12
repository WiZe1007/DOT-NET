using System;

class Task3
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Виведення повідомлення та введення значення x з клавіатури
        Console.Write("Введіть x: ");
        // Читання рядка, конвертація у тип double і присвоєння значення змінній x
        double x = Convert.ToDouble(Console.ReadLine());

        // Виведення повідомлення та введення значення y з клавіатури
        Console.Write("Введіть y: ");
        // Читання рядка, конвертація у тип double і присвоєння значення змінній y
        double y = Convert.ToDouble(Console.ReadLine());

        // Ініціалізація змінних a та b значеннями 12.5 та 1.3 відповідно
        double a = 12.5, b = 1.3;

        // Обчислення значення t1 за формулою з використанням логарифма та степеневих функцій
        double t1 = (1 / Math.Pow(b, 3)) * (Math.Pow(a, 2) * Math.Log(y / x) + (2 * a * x / y) + (Math.Pow(y, 2) / (2 * Math.Pow(x, 2))));

        // Обчислення проміжного значення ax, яке дорівнює добутку a і x
        double ax = a * x;

        // Обчислення значення t2 за іншою формулою з використанням синусоїдальних функцій
        double t2 = (1 / (2 * Math.Sqrt(2) * a)) + ((3 * Math.Pow(Math.Sin(ax), 2) - 1) / (Math.Pow(Math.Sin(ax), 2) - 1));

        // Виведення результатів t1 та t2 на екран
        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");

        Console.ReadLine();  // Затримка перед закриттям програми
    }
}

