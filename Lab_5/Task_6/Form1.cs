using System; // Підключення простору імен System для основних функцій
using System.Drawing; // Підключення простору імен для роботи з графікою (зображення)
using System.Windows.Forms; // Підключення простору імен для створення форм і елементів управління

namespace Task_6 // Визначення простору імен Task_6 для унікальності класів
{
    public partial class Form1 : Form // Оголошення часткового класу Form1, що успадковує форму (Form)
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            this.Load += new EventHandler(Form1_Load); // Додавання обробника події завантаження форми
        }

        private void Form1_Load(object sender, EventArgs e) // Метод, що викликається при завантаженні форми
        {
            InitializePictureBoxes(); // Виклик методу для ініціалізації PictureBox елементів
        }

        private void InitializePictureBoxes() // Метод для додавання PictureBox елементів на форму
        {
            // Перша топологія (горизонтальна лінія)
            PictureBox pictureBox1 = new PictureBox(); // Створення першого PictureBox
            pictureBox1.Image = Image.FromFile(@"C:\1.jpg"); // Завантаження зображення з файлу
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Режим масштабування зображення до розміру PictureBox
            pictureBox1.Location = new Point(10, 60); // Позиція PictureBox на формі
            pictureBox1.Size = new Size(100, 50); // Розмір PictureBox
            this.Controls.Add(pictureBox1); // Додавання PictureBox до елементів форми

            PictureBox pictureBox2 = new PictureBox(); // Створення другого PictureBox
            pictureBox2.Image = Image.FromFile(@"C:\2.jpg"); // Завантаження зображення з файлу
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox2.Location = new Point(120, 60); // Позиція PictureBox
            pictureBox2.Size = new Size(100, 50); // Розмір PictureBox
            this.Controls.Add(pictureBox2); // Додавання PictureBox до форми

            PictureBox pictureBox3 = new PictureBox(); // Створення третього PictureBox
            pictureBox3.Image = Image.FromFile(@"C:\3.jpg"); // Завантаження зображення
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox3.Location = new Point(230, 40); // Позиція PictureBox
            pictureBox3.Size = new Size(100, 70); // Розмір PictureBox
            this.Controls.Add(pictureBox3); // Додавання PictureBox до форми

            PictureBox pictureBox4 = new PictureBox(); // Створення четвертого PictureBox
            pictureBox4.Image = Image.FromFile(@"C:\4.jpg"); // Завантаження зображення
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox4.Location = new Point(340, 25); // Позиція PictureBox
            pictureBox4.Size = new Size(100, 85); // Розмір PictureBox
            this.Controls.Add(pictureBox4); // Додавання PictureBox до форми

            PictureBox pictureBox5 = new PictureBox(); // Створення п'ятого PictureBox
            pictureBox5.Image = Image.FromFile(@"C:\5.jpg"); // Завантаження зображення
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox5.Location = new Point(450, 10); // Позиція PictureBox
            pictureBox5.Size = new Size(100, 100); // Розмір PictureBox
            this.Controls.Add(pictureBox5); // Додавання PictureBox до форми

            // Друга топологія (різні розміри)
            PictureBox pictureBox6 = new PictureBox(); // Створення шостого PictureBox
            pictureBox6.Image = Image.FromFile(@"C:\6.jpg"); // Завантаження зображення
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox6.Location = new Point(10, 120); // Позиція PictureBox
            pictureBox6.Size = new Size(100, 120); // Розмір PictureBox
            this.Controls.Add(pictureBox6); // Додавання PictureBox до форми

            PictureBox pictureBox7 = new PictureBox(); // Створення сьомого PictureBox
            pictureBox7.Image = Image.FromFile(@"C:\7.jpg"); // Завантаження зображення
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox7.Location = new Point(120, 160); // Позиція PictureBox
            pictureBox7.Size = new Size(200, 80); // Розмір PictureBox
            this.Controls.Add(pictureBox7); // Додавання PictureBox до форми

            PictureBox pictureBox8 = new PictureBox(); // Створення восьмого PictureBox
            pictureBox8.Image = Image.FromFile(@"C:\8.jpg"); // Завантаження зображення
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage; // Масштабування зображення
            pictureBox8.Location = new Point(340, 180); // Позиція PictureBox
            pictureBox8.Size = new Size(200, 60); // Розмір PictureBox
            this.Controls.Add(pictureBox8); // Додавання PictureBox до форми
        }
    }
}

