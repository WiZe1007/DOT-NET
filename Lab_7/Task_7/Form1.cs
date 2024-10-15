using System;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
        }

        // Обробник натискання для 1 лейбла
        private void Label_MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Якщо ліва кнопка
            {
                label1.Text = "Змінений текст 1"; // Зміна тексту
            }
        }

        // Обробник відпускання для 1 лейбла
        private void Label_MouseUp1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Якщо ліва кнопка
            {
                label1.Text = "Текст 1"; // Повернення тексту
            }
        }

        // Обробник натискання для 2 лейбла
        private void Label_MouseDown2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Якщо ліва кнопка
            {
                label2.Text = "Змінений текст 2"; // Зміна тексту
            }
        }

        // Обробник відпускання для 2 лейбла
        private void Label_MouseUp2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Якщо ліва кнопка
            {
                label2.Text = "Текст 2"; // Повернення тексту
            }
        }

        // Обробник натискання для 3 лейбла
        private void Label_MouseDown3(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Якщо ліва кнопка
            {
                label3.Text = "Змінений текст 3"; // Зміна тексту
            }
        }

        // Обробник відпускання для 3 лейбла
        private void Label_MouseUp3(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Якщо ліва кнопка
            {
                label3.Text = "Текст 3"; // Повернення тексту
            }
        }
    }
}
