using System;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонента
            AddButtonHandlers();    // Додавання обробників подій для кнопок
        }

        private void AddButtonHandlers()
        {
            // Прив'язка обробника до кнопок
            toolStripButton1.Click += Button_Click;
            toolStripButton2.Click += Button_Click;
            toolStripButton3.Click += Button_Click;
            toolStripButton4.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton button) // Перевірка типу sender
            {
                MessageBox.Show($"Натиснута кнопка {button.Text}"); // Виведення повідомлення
            }
        }
    }
}
