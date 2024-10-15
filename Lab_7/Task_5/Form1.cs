using System;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        // Конструктор форми
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
            CenterButtons(); // Центрування кнопок на формі
            InitializeButtonEvents(); // Налаштування обробників подій для кнопок
        }

        // Центрування кнопок у вікні
        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width; // Ширина форми
            int formHeight = this.ClientSize.Height; // Висота форми

            // Визначення позицій кнопок
            button1.Location = new System.Drawing.Point((formWidth / 2) - 150, (formHeight / 2) - 25);
            button2.Location = new System.Drawing.Point((formWidth / 2) - 50, (formHeight / 2) - 25);
            button3.Location = new System.Drawing.Point((formWidth / 2) + 50, (formHeight / 2) - 25);
        }

        // Налаштування обробників подій для кнопок
        private void InitializeButtonEvents()
        {
            // Додавання обробників для подій MouseEnter та MouseLeave
            button1.MouseEnter += (s, e) => ToggleButtonText(button1);
            button1.MouseLeave += (s, e) => ToggleButtonText(button1);
            button2.MouseEnter += (s, e) => ToggleButtonText(button2);
            button2.MouseLeave += (s, e) => ToggleButtonText(button2);
            button3.MouseEnter += (s, e) => ToggleButtonText(button3);
            button3.MouseLeave += (s, e) => ToggleButtonText(button3);
        }

        // Перемикання тексту кнопки при наведенні
        private void ToggleButtonText(Button button)
        {
            button.Text = button.Text.Contains("Hovered") ?
                button.Text.Replace("Hovered", "Button") :
                button.Text.Replace("Button", "Hovered");
        }
    }
}
