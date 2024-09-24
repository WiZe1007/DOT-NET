using System; // Підключення простору імен для використання основних класів і методів

public class Matrix // Оголошення класу Matrix для роботи з матрицями
{
    private double[,] data; // Двовимірний масив для збереження елементів матриці
    private int rows; // Кількість рядків у матриці
    private int cols; // Кількість стовпців у матриці

    // Конструктор для створення матриці заданого розміру
    public Matrix(int rows, int cols)
    {
        this.rows = rows; // Ініціалізація кількості рядків
        this.cols = cols; // Ініціалізація кількості стовпців
        data = new double[rows, cols]; // Створення матриці з вказаними розмірами
    }

    // Конструктор копіювання
    public Matrix(Matrix other)
    {
        rows = other.rows; // Копіювання кількості рядків
        cols = other.cols; // Копіювання кількості стовпців
        data = new double[rows, cols]; // Створення нової матриці
        Array.Copy(other.data, data, other.data.Length); // Копіювання даних з іншої матриці
    }

    // Метод для копіювання даних з іншої матриці
    public void CopyFrom(Matrix other)
    {
        if (this.rows != other.rows || this.cols != other.cols) // Перевірка розмірів матриць
            throw new ArgumentException("Матриці повинні мати однакові розміри для копіювання.");

        Array.Copy(other.data, this.data, other.data.Length); // Копіювання даних
    }

    // Перевантаження оператора додавання
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.rows != b.rows || a.cols != b.cols) // Перевірка розмірів матриць
            throw new ArgumentException("Матриці повинні мати однакові розміри для додавання.");

        Matrix result = new Matrix(a.rows, a.cols); // Створення нової матриці для результату
        for (int i = 0; i < a.rows; i++) // Проходження по рядках
        {
            for (int j = 0; j < a.cols; j++) // Проходження по стовпцях
            {
                result.data[i, j] = a.data[i, j] + b.data[i, j]; // Додавання відповідних елементів
            }
        }
        return result; // Повернення результату
    }

    // Перевантаження оператора віднімання
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.rows != b.rows || a.cols != b.cols) // Перевірка розмірів матриць
            throw new ArgumentException("Матриці повинні мати однакові розміри для віднімання.");

        Matrix result = new Matrix(a.rows, a.cols); // Створення нової матриці для результату
        for (int i = 0; i < a.rows; i++) // Проходження по рядках
        {
            for (int j = 0; j < a.cols; j++) // Проходження по стовпцях
            {
                result.data[i, j] = a.data[i, j] - b.data[i, j]; // Віднімання відповідних елементів
            }
        }
        return result; // Повернення результату
    }

    // Перевантаження оператора множення
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.cols != b.rows) // Перевірка на можливість множення (кількість стовпців у першій має дорівнювати кількості рядків у другій)
            throw new ArgumentException("Кількість стовпців у першій матриці повинна дорівнювати кількості рядків у другій матриці.");

        Matrix result = new Matrix(a.rows, b.cols); // Створення нової матриці для результату
        for (int i = 0; i < a.rows; i++) // Проходження по рядках
        {
            for (int j = 0; j < b.cols; j++) // Проходження по стовпцях
            {
                for (int k = 0; k < a.cols; k++) // Виконання множення та підсумовування
                {
                    result.data[i, j] += a.data[i, k] * b.data[k, j];
                }
            }
        }
        return result; // Повернення результату
    }

    // Метод для зміни мінору матриці шляхом множення на константу
    public void MultiplyMinor(int row, int col, double constant)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols) // Перевірка правильності індексів
            throw new ArgumentException("Неправильна позиція мінору.");

        data[row, col] *= constant; // Множення елемента на константу
    }

    // Метод для отримання значення елемента матриці
    public double GetValue(int row, int col)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols) // Перевірка правильності індексів
            throw new ArgumentException("Неправильна позиція.");

        return data[row, col]; // Повернення значення елемента
    }

    // Метод для встановлення значення елемента матриці
    public void SetValue(int row, int col, double value)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols) // Перевірка правильності індексів
            throw new ArgumentException("Неправильна позиція.");

        data[row, col] = value; // Встановлення значення елемента
    }

    // Метод для виведення матриці
    public void Print()
    {
        for (int i = 0; i < rows; i++) // Проходження по рядках
        {
            for (int j = 0; j < cols; j++) // Проходження по стовпцях
            {
                Console.Write(data[i, j] + " "); // Виведення елемента з пробілом
            }
            Console.WriteLine(); // Перехід на новий рядок після кожного рядка матриці
        }
    }
}

class Task_3
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для вводу
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодування для виводу

        // Створення масиву об'єктів матриці
        Matrix[] matrices = new Matrix[2];
        matrices[0] = new Matrix(2, 2); // Ініціалізація першої матриці
        matrices[1] = new Matrix(2, 2); // Ініціалізація другої матриці

        // Заповнення матриць випадковими значеннями
        Random rand = new Random(); // Створення генератора випадкових чисел
        for (int k = 0; k < matrices.Length; k++) // Проходження по кожній матриці
        {
            for (int i = 0; i < 2; i++) // Проходження по рядках
            {
                for (int j = 0; j < 2; j++) // Проходження по стовпцях
                {
                    matrices[k].SetValue(i, j, rand.Next(1, 10)); // Встановлення випадкового значення
                }
            }
        }

        // Виведення початкових матриць
        Console.WriteLine("Матриця 1:");
        matrices[0].Print(); // Виведення першої матриці
        Console.WriteLine("Матриця 2:");
        matrices[1].Print(); // Виведення другої матриці

        // Додавання матриць
        Matrix sum = matrices[0] + matrices[1]; // Сума матриць
        Console.WriteLine("Сума матриць:");
        sum.Print(); // Виведення результату

        // Віднімання матриць
        Matrix diff = matrices[0] - matrices[1]; // Різниця матриць
        Console.WriteLine("Різниця матриць:");
        diff.Print(); // Виведення результату

        // Множення матриць
        Matrix product = matrices[0] * matrices[1]; // Добуток матриць
        Console.WriteLine("Добуток матриць:");
        product.Print(); // Виведення результату

        // Зміна мінору матриці
        matrices[0].MultiplyMinor(0, 0, 2); // Множення мінору першої матриці на 2
        Console.WriteLine("Матриця 1 після множення мінору на 2:");
        matrices[0].Print(); // Виведення результату

        Console.ReadKey(); // Очікування натискання клавіші
    }
}

