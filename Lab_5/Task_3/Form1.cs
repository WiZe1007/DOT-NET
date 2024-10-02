using System; // Підключення простору імен для базових класів
using System.Drawing; // Підключення простору імен для графіки та роботи з кольорами
using System.Windows.Forms; // Підключення простору імен для створення віконних додатків

namespace test
{
    public partial class Form1 : Form
    {
        // Конструктор класу Form1
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів форми
        }

        // Метод, який викликається під час завантаження форми
        private void Form_Load(object sender, EventArgs e)
        {
            // Створення першого текстового поля
            TextBox textBox1 = new TextBox(); // Ініціалізація текстового поля
            textBox1.Text = "Перший рядок"; // Встановлення тексту для текстового поля
            textBox1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic); // Налаштування шрифту: Arial, 16 пунктів, жирний і курсив
            textBox1.ForeColor = Color.Pink; // Колір тексту рожевий
            textBox1.BackColor = Color.Green; // Фон текстового поля зелений
            textBox1.TextAlign = HorizontalAlignment.Left; // Вирівнювання тексту зліва
            textBox1.Dock = DockStyle.Top; // Розташування текстового поля у верхній частині форми
            textBox1.ReadOnly = true; // Поле тільки для читання

            // Створення другого текстового поля
            TextBox textBox2 = new TextBox(); // Ініціалізація другого текстового поля
            textBox2.Text = "Другий рядок"; // Встановлення тексту для текстового поля
            textBox2.Font = new Font("Arial", 14, FontStyle.Italic | FontStyle.Underline); // Налаштування шрифту: Arial, 14 пунктів, курсив та підкреслення
            textBox2.ForeColor = Color.Blue; // Колір тексту синій
            textBox2.BackColor = Color.Red; // Фон текстового поля червоний
            textBox2.TextAlign = HorizontalAlignment.Right; // Вирівнювання тексту праворуч
            textBox2.Dock = DockStyle.Top; // Розташування текстового поля у верхній частині форми
            textBox2.ReadOnly = true; // Поле тільки для читання

            // Створення третього текстового поля
            TextBox textBox3 = new TextBox(); // Ініціалізація третього текстового поля
            textBox3.Text = "Третій рядок"; // Встановлення тексту для текстового поля
            textBox3.Font = new Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); // Налаштування шрифту: Arial, 17 пунктів, жирний, курсив та підкреслення
            textBox3.ForeColor = Color.LightBlue; // Колір тексту світло-блакитний
            textBox3.BackColor = Color.Yellow; // Фон текстового поля жовтий
            textBox3.TextAlign = HorizontalAlignment.Center; // Вирівнювання тексту по центру
            textBox3.Dock = DockStyle.Top; // Розташування текстового поля у верхній частині форми
            textBox3.ReadOnly = true; // Поле тільки для читання

            // Додавання текстових полів до форми
            this.Controls.Add(textBox3); // Додаємо третє текстове поле
            this.Controls.Add(textBox2); // Додаємо друге текстове поле
            this.Controls.Add(textBox1); // Додаємо перше текстове поле
        }

        [STAThread] // Вказує, що програма повинна використовувати один потік для інтерфейсу
        public static void Main()
        {
            Application.EnableVisualStyles(); // Включення стилів для кращої графічної інтерфейсної віддачі
            Application.SetCompatibleTextRenderingDefault(false); // Встановлення сумісного рендерингу тексту
            Application.Run(new Form1()); // Запуск форми Form1
        }
    }
}

