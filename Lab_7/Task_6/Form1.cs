using System;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
            CenterButtons(); // Центрування кнопок
        }

        // Метод для центрування кнопок
        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width; // Ширина форми
            int formHeight = this.ClientSize.Height; // Висота форми

            // Встановлення позицій кнопок
            button1.Location = new System.Drawing.Point((formWidth / 2) - 150, (formHeight / 2) - 25);
            button2.Location = new System.Drawing.Point((formWidth / 2) - 50, (formHeight / 2) - 25);
            button3.Location = new System.Drawing.Point((formWidth / 2) + 50, (formHeight / 2) - 25);
        }

        // Обробка наведенні миші на кнопку
        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button; // Приведення до кнопки
            if (button != null) // Перевірка
            {
                // Зміна тексту кнопки
                if (button.Text.Contains("Button"))
                {
                    button.Text = button.Text.Replace("Button", "Hovered"); // При наведенні
                }
                else if (button.Text.Contains("Hovered"))
                {
                    button.Text = button.Text.Replace("Hovered", "Button"); // При виході
                }
            }
        }
    }
}
