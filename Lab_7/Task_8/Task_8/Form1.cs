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
                // Зміна тексту мітки за допомогою switch expression
                label.Text = label.Text switch
                {
                    "Текст 1" => "Змінений текст 1",
                    "Текст 2" => "Змінений текст 2",
                    "Текст 3" => "Змінений текст 3",
                    "Змінений текст 1" => "Текст 1",
                    "Змінений текст 2" => "Текст 2",
                    "Змінений текст 3" => "Текст 3",
                    _ => label.Text // Повернення поточного тексту, якщо немає збігу
                };
            }
        }
    }
}
