using System;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        // Конструктор форми
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
        }

        // Обробник миші для міток
        private void Label_MouseHandler(object sender, MouseEventArgs e)
        {
            // Перевірка на лівий клік миші
            if (sender is Label label && e.Button == MouseButtons.Left)
            {
                // Зміна тексту мітки
                switch (label.Text)
                {
                    case "Текст 1":
                        label.Text = "Змінений текст 1";
                        break;
                    case "Текст 2":
                        label.Text = "Змінений текст 2";
                        break;
                    case "Текст 3":
                        label.Text = "Змінений текст 3";
                        break;
                    // Повернення до початкового тексту
                    case "Змінений текст 1":
                        label.Text = "Текст 1";
                        break;
                    case "Змінений текст 2":
                        label.Text = "Текст 2";
                        break;
                    case "Змінений текст 3":
                        label.Text = "Текст 3";
                        break;
                }
            }
        }
    }
}
