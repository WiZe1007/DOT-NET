using System;
using System.Windows.Forms;

namespace Task_003
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent(); // Ініціалізація форм
            InitializeLabelEvents(); // Налаштування подій міток
        }

        // Налаштування подій для міток
        private void InitializeLabelEvents()
        {
            label1.DoubleClick += (s, e) => ToggleLabelText(label1, "Label 1", "New Text 1"); // Подвійний клік на label1
            label2.DoubleClick += (s, e) => ToggleLabelText(label2, "Label 2", "New Text 2"); // Подвійний клік на label2
            label3.DoubleClick += (s, e) => ToggleLabelText(label3, "Label 3", "New Text 3"); // Подвійний клік на label3
        }

        // Зміна тексту мітки
        private void ToggleLabelText(System.Windows.Forms.Label label, string text1, string text2)
        {
            // Переключення між текстами
            if (label.Text == text1)
            {
                label.Text = text2; // Зміна на новий текст
            }
            else
            {
                label.Text = text1; // Повернення до старого тексту
            }
        }
    }
}
