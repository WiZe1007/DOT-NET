using System;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
            InitializeButtons(); // Виклик методу для створення кнопок
            displayTimer.Tick += (s, e) => DisplayTimer_Tick(); // Підключення обробника події таймера
        }

        private void InitializeButtons()
        {
            // Створення кнопок для інтерфейсу
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

            // Визначення позицій кнопок на формі
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int spacing = 10;

            // Обчислення позицій для кнопок
            button1.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, (formHeight - (3 * buttonHeight + 2 * spacing)) / 2);
            button2.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, button1.Location.Y + buttonHeight + spacing);
            button3.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, button2.Location.Y + buttonHeight + spacing);

            // Додавання обробників подій для кнопок
            button1.Click += (s, e) => ShowMessage("Кнопка 1"); 
            button2.Click += (s, e) => ShowMessage("Кнопка 2"); 
            button3.Click += (s, e) => ShowMessage("Кнопка 3"); 

            // Додавання кнопок на форму
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
        }

        private void ShowMessage(string buttonText)
        {
            // Відображення тексту на мітці та показ панелі
            displayLabel.Text = $"Ви натиснули: {buttonText}";
            displayPanel.Visible = true; // Показати панель
            displayTimer.Start(); // Запустити таймер для автомат закриття
        }

        private void DisplayTimer_Tick()
        {
            // Скидання тексту мітки і приховування панелі
            displayLabel.Text = string.Empty; // Очистка тексту
            displayPanel.Visible = false; // Сховати панель
            displayTimer.Stop(); // Зупинка таймера
        }
    }
}
