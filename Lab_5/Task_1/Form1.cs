using System; // Підключення бібліотеки для базових функцій C#
using System.Drawing; // Підключення бібліотеки для роботи з графікою
using System.Windows.Forms; // Підключення бібліотеки для створення віконних додатків

namespace Task_1
{
    public partial class Form1 : Form // Оголошення класу Form1, який успадковує клас Form
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів (визначена в Form1.Designer.cs)

            // Налаштування першого рядка
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label(); // Створення нового елементу Label (мітка)
            label1.Text = "Перший рядок"; // Встановлення тексту для першого рядка
            label1.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold | FontStyle.Italic); // Задання шрифту, його розміру і стилю (жирний, курсив)
            label1.ForeColor = Color.Pink; // Колір тексту - рожевий
            label1.BackColor = Color.Green; // Фоновий колір - зелений
            label1.TextAlign = ContentAlignment.MiddleLeft; // Вирівнювання тексту по лівому краю
            label1.Dock = DockStyle.Top; // Розташування мітки зверху вікна

            // Налаштування другого рядка
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label(); // Створення другого елементу Label
            label2.Text = "Другий рядок"; // Встановлення тексту для другого рядка
            label2.Font = new System.Drawing.Font("Arial", 14, FontStyle.Italic | FontStyle.Underline); // Задання шрифту зі стилем курсиву та підкреслення
            label2.ForeColor = Color.Blue; // Колір тексту - синій
            label2.BackColor = Color.Red; // Фоновий колір - червоний
            label2.TextAlign = ContentAlignment.MiddleRight; // Вирівнювання тексту по правому краю
            label2.Dock = DockStyle.Top; // Розташування мітки зверху (під попередньою міткою)

            // Налаштування третього рядка
            System.Windows.Forms.Label label3 = new System.Windows.Forms.Label(); // Створення третього елементу Label
            label3.Text = "Третій рядок"; // Встановлення тексту для третього рядка
            label3.Font = new System.Drawing.Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); // Шрифт із трьома стилями: жирний, курсив, підкреслення
            label3.ForeColor = Color.LightBlue; // Колір тексту - світло-блакитний
            label3.BackColor = Color.Yellow; // Фоновий колір - жовтий
            label3.TextAlign = ContentAlignment.MiddleCenter; // Вирівнювання тексту по центру
            label3.Dock = DockStyle.Top; // Розташування мітки зверху (під другим рядком)

            // Додавання рядків до форми
            this.Controls.Add(label3); // Додавання третього рядка на форму
            this.Controls.Add(label2); // Додавання другого рядка на форму
            this.Controls.Add(label1); // Додавання першого рядка на форму
        }

        [STAThread] // Вказує на те, що головний потік є однопоточним (Single Threaded Apartment)
        public static void Main() // Головна функція програми
        {
            Application.EnableVisualStyles(); // Увімкнення візуальних стилів для форми
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Запуск додатку з головною формою Form1
        }
    }
}

