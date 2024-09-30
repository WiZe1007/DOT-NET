using System; // Підключення простору імен System для базових функцій
using System.Drawing; // Підключення простору імен для роботи з графікою
using System.Windows.Forms; // Підключення простору імен для створення форми

// Створення класу Task_4, який наслідує клас Form
public class Task_4 : Form
{
    // Конструктор класу Task_4
    public Task_4()
    {
        // Встановлюємо заголовок форми
        this.Text = "Task_4";

        // Встановлюємо розмір форми
        this.Size = new Size(400, 300);

        // Додаємо обробник події завантаження форми
        this.Load += new EventHandler(Form_Load);
    }

    // Метод, який виконується при завантаженні форми
    private void Form_Load(object sender, EventArgs e)
    {
        // Створюємо текстове поле textBox1
        TextBox textBox1 = new TextBox();
        // Встановлюємо текст для першого рядка
        textBox1.Text = "Перший рядок";
        // Встановлюємо шрифт Arial 16, напівжирний і курсивний
        textBox1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
        // Встановлюємо колір тексту рожевим
        textBox1.ForeColor = Color.Pink;
        // Встановлюємо колір фону зеленим
        textBox1.BackColor = Color.Green;
        // Вирівнюємо текст по лівому краю
        textBox1.TextAlign = HorizontalAlignment.Left;
        // Закріплюємо поле зверху форми
        textBox1.Dock = DockStyle.Top;
        // Робимо поле тільки для читання
        textBox1.ReadOnly = true;

        // Створюємо текстове поле textBox2
        TextBox textBox2 = new TextBox();
        // Встановлюємо текст для другого рядка
        textBox2.Text = "Другий рядок";
        // Встановлюємо шрифт Arial 14, курсивний і підкреслений
        textBox2.Font = new Font("Arial", 14, FontStyle.Italic | FontStyle.Underline);
        // Встановлюємо колір тексту синім
        textBox2.ForeColor = Color.Blue;
        // Встановлюємо колір фону червоним
        textBox2.BackColor = Color.Red;
        // Вирівнюємо текст по правому краю
        textBox2.TextAlign = HorizontalAlignment.Right;
        // Закріплюємо поле зверху форми (над попереднім)
        textBox2.Dock = DockStyle.Top;
        // Робимо поле тільки для читання
        textBox2.ReadOnly = true;

        // Створюємо текстове поле textBox3
        TextBox textBox3 = new TextBox();
        // Встановлюємо текст для третього рядка
        textBox3.Text = "Третій рядок";
        // Встановлюємо шрифт Arial 17, напівжирний, курсивний і підкреслений
        textBox3.Font = new Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
        // Встановлюємо колір тексту світло-блакитним
        textBox3.ForeColor = Color.LightBlue;
        // Встановлюємо колір фону жовтим
        textBox3.BackColor = Color.Yellow;
        // Вирівнюємо текст по центру
        textBox3.TextAlign = HorizontalAlignment.Center;
        // Закріплюємо поле зверху форми (над попередніми)
        textBox3.Dock = DockStyle.Top;
        // Робимо поле тільки для читання
        textBox3.ReadOnly = true;

        // Додаємо всі три поля до форми
        this.Controls.Add(textBox3);
        this.Controls.Add(textBox2);
        this.Controls.Add(textBox1);
    }

    // Метод Main, який є точкою входу в програму
    [STAThread]
    public static void Main()
    {
        // Увімкнення візуальних стилів додатку
        Application.EnableVisualStyles();
        // Запуск форми Task_4
        Application.Run(new Task_4());
    }
}

