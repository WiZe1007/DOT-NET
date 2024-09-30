using System; // Підключення простору імен System, що містить базові класи .NET
using System.Drawing; // Підключення простору імен для роботи з графікою та зображеннями
using System.Windows.Forms; // Підключення простору імен для створення та роботи з формами Windows Forms

namespace WinFormsApp1 // Оголошення простору імен для цього додатку
{
    public partial class Form1 : Form // Оголошення класу Form1, який є частковим класом і успадковується від класу Form
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            InitializePictureBoxes(); // Виклик методу для ініціалізації та додавання PictureBox елементів на форму
        }

        private void InitializePictureBoxes() // Метод для ініціалізації та розміщення PictureBox елементів
        {
            // Перша топологія (горизонтальна лінія)
            PictureBox pictureBox1 = new PictureBox(); // Створення PictureBox для першого зображення
            pictureBox1.Image = Image.FromFile(@"C:\1.jpg"); // Завантаження зображення з файлу
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox1.Location = new Point(10, 60); // Встановлення положення PictureBox на формі
            pictureBox1.Size = new Size(100, 50); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox1); // Додавання PictureBox на форму

            PictureBox pictureBox2 = new PictureBox(); // Створення PictureBox для другого зображення
            pictureBox2.Image = Image.FromFile(@"C:\2.jpg"); // Завантаження другого зображення з файлу
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox2.Location = new Point(120, 60); // Встановлення положення PictureBox на формі
            pictureBox2.Size = new Size(100, 50); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox2); // Додавання PictureBox на форму

            PictureBox pictureBox3 = new PictureBox(); // Створення PictureBox для третього зображення
            pictureBox3.Image = Image.FromFile(@"C:\3.jpg"); // Завантаження третього зображення з файлу
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox3.Location = new Point(230, 40); // Встановлення положення PictureBox на формі
            pictureBox3.Size = new Size(100, 70); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox3); // Додавання PictureBox на форму

            PictureBox pictureBox4 = new PictureBox(); // Створення PictureBox для четвертого зображення
            pictureBox4.Image = Image.FromFile(@"C:\4.jpg"); // Завантаження четвертого зображення з файлу
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox4.Location = new Point(340, 25); // Встановлення положення PictureBox на формі
            pictureBox4.Size = new Size(100, 85); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox4); // Додавання PictureBox на форму

            PictureBox pictureBox5 = new PictureBox(); // Створення PictureBox для п'ятого зображення
            pictureBox5.Image = Image.FromFile(@"C:\5.jpg"); // Завантаження п'ятого зображення з файлу
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox5.Location = new Point(450, 10); // Встановлення положення PictureBox на формі
            pictureBox5.Size = new Size(100, 100); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox5); // Додавання PictureBox на форму

            // Друга топологія (різні розміри)
            PictureBox pictureBox6 = new PictureBox(); // Створення PictureBox для шостого зображення
            pictureBox6.Image = Image.FromFile(@"C:\6.jpg"); // Завантаження шостого зображення з файлу
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox6.Location = new Point(10, 120); // Встановлення положення PictureBox на формі
            pictureBox6.Size = new Size(100, 120); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox6); // Додавання PictureBox на форму

            PictureBox pictureBox7 = new PictureBox(); // Створення PictureBox для сьомого зображення
            pictureBox7.Image = Image.FromFile(@"C:\7.jpg"); // Завантаження сьомого зображення з файлу
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox7.Location = new Point(120, 160); // Встановлення положення PictureBox на формі
            pictureBox7.Size = new Size(200, 80); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox7); // Додавання PictureBox на форму

            PictureBox pictureBox8 = new PictureBox(); // Створення PictureBox для восьмого зображення
            pictureBox8.Image = Image.FromFile(@"C:\8.jpg"); // Завантаження восьмого зображення з файлу
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлення режиму відображення - зображення буде розтягуватись
            pictureBox8.Location = new Point(340, 180); // Встановлення положення PictureBox на формі
            pictureBox8.Size = new Size(200, 60); // Встановлення розміру PictureBox
            this.Controls.Add(pictureBox8); // Додавання PictureBox на форму
        }
    }
}

