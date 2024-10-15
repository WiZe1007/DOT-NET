using System;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
            CenterTextBox(); // Центруємо текстове поле
        }

        private void CenterTextBox()
        {
            // Центруємо textBox1 в формі
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            textBox1.Top = (this.ClientSize.Height - textBox1.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Центруємо текстове поле при зміні розміру
            CenterTextBox();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Дозволяємо лише парні цифри
            if (char.IsDigit(e.KeyChar))
            {
                int digit = int.Parse(e.KeyChar.ToString());
                if (digit % 2 != 0) e.Handled = true; // Блокуємо непарні
            }
            else if (!char.IsControl(e.KeyChar)) e.Handled = true; // Блокуємо інші символи
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Очищення текстового поля при натисканні Esc
            if (e.KeyCode == Keys.Escape) textBox1.Clear();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // Виводимо відпущену клавішу
            Console.WriteLine($"Key released: {e.KeyCode}");
        }
    }
}
