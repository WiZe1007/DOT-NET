using System;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            InitializeButtons(); // Виклик методу для налаштування кнопок
        }

        private void InitializeButtons()
        {
            // Створення кнопок
            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();

            // Встановлення тексту на кнопках
            button1.Text = "Кнопка 1";
            button2.Text = "Кнопка 2";
            button3.Text = "Кнопка 3";

            // Встановлення розмірів кнопок
            int buttonWidth = 100;
            int buttonHeight = 30;
            button1.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button2.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button3.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            // Встановлення розташування кнопок
            int formWidth = this.ClientSize.Width; // Ширина форми
            int formHeight = this.ClientSize.Height; // Висота форми
            int spacing = 10; // Відстань між кнопками

            // Розташування кнопок по центру форми
            button1.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, (formHeight - (3 * buttonHeight + 2 * spacing)) / 2);
            button2.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, button1.Location.Y + buttonHeight + spacing);
            button3.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, button2.Location.Y + buttonHeight + spacing);

            // Додавання обробників подій для кнопок
            button1.Click += new EventHandler(Button_Click);
            button2.Click += new EventHandler(Button_Click);
            button3.Click += new EventHandler(Button_Click);

            // Додавання кнопок на форму
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Обробка натискання кнопки
            Button clickedButton = sender as Button; // Отримання кнопки, яка була натиснута
            if (clickedButton != null)
            {
                displayLabel.Text = $"Ви натиснули: {clickedButton.Text}"; // Відображення тексту
                displayPanel.Visible = true; // Показати панель
                displayTimer.Start(); // Запустити таймер
            }
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            // Дія при спрацьовуванні таймера
            displayLabel.Text = string.Empty; // Очистити текст
            displayPanel.Visible = false; // Сховати панель
            displayTimer.Stop(); // Зупинити таймер
        }
    }
}
