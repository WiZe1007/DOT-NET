using System; // Підключення простору імен для базових класів
using System.Drawing; // Підключення простору імен для графіки та роботи з кольорами
using System.Windows.Forms; // Підключення простору імен для створення віконних додатків

// Оголошення класу Task_3, який наслідується від класу Form
public class Task_3 : Form
{
    // Конструктор класу Task_3
    public Task_3()
    {
        // Встановлення заголовка форми
        this.Text = "Task_3";
        // Встановлення розміру форми
        this.Size = new Size(400, 300);
        // Прив'язка обробника події завантаження форми
        this.Load += new EventHandler(Form_Load);
    }

    // Метод, який викликається під час завантаження форми
    private void Form_Load(object sender, EventArgs e)
    {
        // Створення першого текстового поля
        TextBox textBox1 = new TextBox();
        // Встановлення тексту в першому рядку
        textBox1.Text = "Перший рядок";
        // Налаштування шрифту: Arial, 16 розмір, жирний і курсив
        textBox1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
        // Колір тексту - рожевий
        textBox1.ForeColor = Color.Pink;
        // Колір фону - зелений
        textBox1.BackColor = Color.Green;
        // Вирівнювання тексту ліворуч
        textBox1.TextAlign = HorizontalAlignment.Left;
        // Прив'язка елемента до верхнього краю форми
        textBox1.Dock = DockStyle.Top;
        // Встановлення поля лише для читання
        textBox1.ReadOnly = true;

        // Створення другого текстового поля
        TextBox textBox2 = new TextBox();
        // Встановлення тексту у другому рядку
        textBox2.Text = "Другий рядок";
        // Налаштування шрифту: Arial, 14 розмір, курсив і підкреслений
        textBox2.Font = new Font("Arial", 14, FontStyle.Italic | FontStyle.Underline);
        // Колір тексту - синій
        textBox2.ForeColor = Color.Blue;
        // Колір фону - червоний
        textBox2.BackColor = Color.Red;
        // Вирівнювання тексту праворуч
        textBox2.TextAlign = HorizontalAlignment.Right;
        // Прив'язка елемента до верхнього краю форми
        textBox2.Dock = DockStyle.Top;
        // Встановлення поля лише для читання
        textBox2.ReadOnly = true;

        // Створення третього текстового поля
        TextBox textBox3 = new TextBox();
        // Встановлення тексту в третьому рядку
        textBox3.Text = "Третій рядок";
        // Налаштування шрифту: Arial, 17 розмір, жирний, курсив, підкреслений
        textBox3.Font = new Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        // Колір тексту - світло-блакитний
        textBox3.ForeColor = Color.LightBlue;
        // Колір фону - жовтий
        textBox3.BackColor = Color.Yellow;
        // Вирівнювання тексту по центру
        textBox3.TextAlign = HorizontalAlignment.Center;
        // Прив'язка елемента до верхнього краю форми
        textBox3.Dock = DockStyle.Top;
        // Встановлення поля лише для читання
        textBox3.ReadOnly = true;

        // Додавання третього текстового поля до форми
        this.Controls.Add(textBox3);
        // Додавання другого текстового поля до форми
        this.Controls.Add(textBox2);
        // Додавання першого текстового поля до форми
        this.Controls.Add(textBox1);
    }

    // Головний метод для запуску програми
    [STAThread]
    public static void Main()
    {
        // Увімкнення візуальних стилів
        Application.EnableVisualStyles();
        // Запуск програми з головною формою Task_3
        Application.Run(new Task_3());
    }
}

