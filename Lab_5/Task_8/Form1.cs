using System; // Підключення простору імен для загальних функцій
using System.Windows.Forms; // Підключення простору імен для створення форм та елементів керування

namespace Task_8 // Оголошення простору імен Task_8 для структурування коду
{
    public partial class Form1 : Form // Оголошення класу Form1, який є частиною форми та успадковується від класу Form
    {
        private Button but1; // Оголошення кнопки but1
        private Button but2; // Оголошення кнопки but2
        private Button but3; // Оголошення кнопки but3
        private Button but4; // Оголошення кнопки but4
        private Button but5; // Оголошення кнопки but5
        private TableLayoutPanel tableLayoutPanel; // Оголошення панелі TableLayoutPanel

        public Form1() // Конструктор форми
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            this.Load += Form1_Load; // Підписка на подію Load, яка викликається при завантаженні форми
        }

        private void Form1_Load(object sender, EventArgs e) // Обробник події завантаження форми
        {
            // Створення TableLayoutPanel, таблиці для розміщення елементів керування
            tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 4, // Задання кількості рядків у таблиці (4 рядки)
                ColumnCount = 3, // Задання кількості стовпців у таблиці (3 стовпці)
                Dock = DockStyle.Fill // Розтягування таблиці на весь доступний простір форми
            };

            // Додавання стилів для рядків таблиці
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Перший рядок займає 25% висоти для but5
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Другий рядок займає 25% висоти для but1
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Третій рядок займає 25% висоти для but3, but2, but4
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Четвертий рядок, порожній, займає 25% висоти
            // Додавання стилів для стовпців таблиці
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Лівий стовпець займає 33.33% ширини
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Середній стовпець займає 33.33% ширини
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Правий стовпець займає 33.33% ширини

            // Створення кнопок та задання тексту для них
            but1 = new Button { Text = "but1" }; // Створення кнопки but1 з текстом "but1"
            but2 = new Button { Text = "but2" }; // Створення кнопки but2 з текстом "but2"
            but3 = new Button { Text = "but3" }; // Створення кнопки but3 з текстом "but3"
            but4 = new Button { Text = "but4" }; // Створення кнопки but4 з текстом "but4"
            but5 = new Button { Text = "but5" }; // Створення кнопки but5 з текстом "but5"

            // Додавання кнопок до відповідних позицій у таблиці
            tableLayoutPanel.Controls.Add(but5, 1, 0); // Додавання but5 у перший рядок, середній стовпець
            tableLayoutPanel.Controls.Add(but1, 1, 1); // Додавання but1 у другий рядок, середній стовпець
            tableLayoutPanel.Controls.Add(but3, 0, 2); // Додавання but3 у третій рядок, лівий стовпець
            tableLayoutPanel.Controls.Add(but2, 1, 2); // Додавання but2 у третій рядок, середній стовпець
            tableLayoutPanel.Controls.Add(but4, 2, 2); // Додавання but4 у третій рядок, правий стовпець

            // Додавання TableLayoutPanel до форми для відображення на екрані
            this.Controls.Add(tableLayoutPanel);
        }
    }
}

