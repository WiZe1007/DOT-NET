using System; // Підключення простору імен System для базових функцій та класів.
using System.Drawing; // Підключення простору імен для роботи з графічними елементами, шрифтами, кольорами тощо.
using System.Windows.Forms; // Підключення простору імен для створення графічного інтерфейсу користувача.

namespace test // Оголошення простору імен під назвою 'test', в якому містяться всі елементи цього класу.
{
    public partial class Form1 : Form // Оголошення класу Form1, що успадковує властивості та методи класу Form (форма).
    {
        // Конструктор класу Form1
        public Form1()
        {
            InitializeComponent(); // Виклик методу ініціалізації компонентів форми, який генерується автоматично.
        }

        // Метод, який виконується при завантаженні форми
        private void Form_Load(object sender, EventArgs e)
        {
            // Створюємо текстове поле textBox1
            TextBox textBox1 = new TextBox(); // Ініціалізація нового текстового поля.
            textBox1.Text = "Перший рядок"; // Встановлення тексту в поле.
            textBox1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic); // Налаштування шрифту: Arial, 16 пт, жирний і курсив.
            textBox1.ForeColor = Color.Pink; // Встановлення кольору тексту - рожевий.
            textBox1.BackColor = Color.Green; // Встановлення кольору фону - зелений.
            textBox1.TextAlign = HorizontalAlignment.Left; // Вирівнювання тексту по лівому краю.
            textBox1.Dock = DockStyle.Top; // Прив'язка текстового поля до верхньої частини форми.
            textBox1.ReadOnly = true; // Поле тільки для читання, не можна змінювати текст.

            // Створюємо текстове поле textBox2
            TextBox textBox2 = new TextBox(); // Ініціалізація другого текстового поля.
            textBox2.Text = "Другий рядок"; // Встановлення тексту.
            textBox2.Font = new Font("Arial", 14, FontStyle.Italic | FontStyle.Underline); // Шрифт: Arial, 14 пт, курсив і підкреслений.
            textBox2.ForeColor = Color.Blue; // Колір тексту - синій.
            textBox2.BackColor = Color.Red; // Колір фону - червоний.
            textBox2.TextAlign = HorizontalAlignment.Right; // Вирівнювання тексту по правому краю.
            textBox2.Dock = DockStyle.Top; // Прив'язка текстового поля до верхньої частини форми.
            textBox2.ReadOnly = true; // Поле лише для читання.

            // Створюємо текстове поле textBox3
            TextBox textBox3 = new TextBox(); // Ініціалізація третього текстового поля.
            textBox3.Text = "Третій рядок"; // Встановлення тексту.
            textBox3.Font = new Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); // Шрифт: Arial, 17 пт, жирний, курсив і підкреслений.
            textBox3.ForeColor = Color.LightBlue; // Колір тексту - світло-блакитний.
            textBox3.BackColor = Color.Yellow; // Колір фону - жовтий.
            textBox3.TextAlign = HorizontalAlignment.Center; // Вирівнювання тексту по центру.
            textBox3.Dock = DockStyle.Top; // Прив'язка текстового поля до верхньої частини форми.
            textBox3.ReadOnly = true; // Поле тільки для читання.

            // Додаємо всі три поля до форми
            this.Controls.Add(textBox3); // Додавання третього текстового поля до форми.
            this.Controls.Add(textBox2); // Додавання другого текстового поля до форми.
            this.Controls.Add(textBox1); // Додавання першого текстового поля до форми.
        }

        // Метод Main, який є точкою входу в програму
        [STAThread] // Означає, що головний потік буде однопотоковий і буде використовувати модель STA (Single Threaded Apartment).
        public static void Main() // Головний метод програми, з якого починається виконання.
        {
            Application.EnableVisualStyles(); // Увімкнення візуальних стилів для додатку.
            Application.Run(new Form1()); // Запуск додатку з формою Form1.
        }
    }
}

