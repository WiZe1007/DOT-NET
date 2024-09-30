using System; // Підключення простору імен для основних функцій
using System.Windows.Forms; // Підключення простору імен для роботи з формами

namespace Task_7 // Оголошення простору імен Task_7
{
    public partial class Form1 : Form // Оголошення класу Form1, який є частковим та наслідується від класу Form
    {
        private Button but1; // Оголошення кнопки but1
        private Button but2; // Оголошення кнопки but2
        private Button but3; // Оголошення кнопки but3
        private Button but4; // Оголошення кнопки but4
        private Button but5; // Оголошення кнопки but5
        private TableLayoutPanel tableLayoutPanel; // Оголошення компонента TableLayoutPanel для розміщення елементів

        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів форми

            // Створення TableLayoutPanel
            tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 4, // Встановлення кількості рядків у таблиці (4 рядки)
                ColumnCount = 3, // Встановлення кількості стовпців у таблиці (3 стовпці)
                Dock = DockStyle.Fill // Автоматичне заповнення форми TableLayoutPanel
            };

            // Додавання рядків та стовпців
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Перший рядок: займає 25% висоти для but5
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Другий рядок: 25% висоти для but1
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Третій рядок: 25% для but3, but2, but4
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Четвертий рядок: порожній, займає 25% висоти
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Лівий стовпець, 33.33% ширини
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Середній стовпець, 33.33% ширини
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F)); // Правий стовпець, 33.33% ширини

            // Створення кнопок
            but1 = new Button { Text = "but1" }; // Ініціалізація кнопки but1 з текстом "but1"
            but2 = new Button { Text = "but2" }; // Ініціалізація кнопки but2 з текстом "but2"
            but3 = new Button { Text = "but3" }; // Ініціалізація кнопки but3 з текстом "but3"
            but4 = new Button { Text = "but4" }; // Ініціалізація кнопки but4 з текстом "but4"
            but5 = new Button { Text = "but5" }; // Ініціалізація кнопки but5 з текстом "but5"

            // Додавання кнопок до TableLayoutPanel
            tableLayoutPanel.Controls.Add(but5, 1, 0); // Додавання кнопки but5 у верхній ряд, середній стовпець
            tableLayoutPanel.Controls.Add(but1, 1, 1); // Додавання кнопки but1 у другий ряд, середній стовпець
            tableLayoutPanel.Controls.Add(but3, 0, 2); // Додавання кнопки but3 у третій ряд, лівий стовпець
            tableLayoutPanel.Controls.Add(but2, 1, 2); // Додавання кнопки but2 у третій ряд, середній стовпець
            tableLayoutPanel.Controls.Add(but4, 2, 2); // Додавання кнопки but4 у третій ряд, правий стовпець

            // Додавання TableLayoutPanel до форми
            this.Controls.Add(tableLayoutPanel); // Додає TableLayoutPanel до колекції елементів управління форми
        }
    }
}

