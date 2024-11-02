using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_8 : Form
    {
        public Task_8()
        {
            InitializeComponent();
            UpdateDateTimeLabel();  // ініціалізація дати й часу
            UpdateTextLabel("");    // ініціалізація тексту
        }

        // Оновлення дати й часу
        private void UpdateDateTimeLabel()
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // Текст в зворотному порядку
        private void UpdateTextLabel(string inputText)
        {
            // Реверс та зміна регістру
            var reversedText = new string(inputText
                .Select(c => char.IsLetter(c)
                    ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) // зміна регістру
                    : c) // залишає пробіли
                .Reverse() // реверс рядка
                .ToArray());

            toolStripStatusLabel2.Text = reversedText; // відображення тексту
        }

        // Обробка зміни тексту в текстовому полі
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimeLabel(); // оновлення дати й часу
            UpdateTextLabel(textBox1.Text); // оновлення тексту
        }

        // Показ форми при подвійному кліку по іконці
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        // Показ форми
        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        // Приховування форми
        private void HideMenuItem_Click(object sender, EventArgs e)
        {
            HideForm();
        }

        // Закриття додатка
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Показ форми
        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        // Приховування форми
        private void HideForm()
        {
            this.Hide();
        }

        // Закриття додатка
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // завершення роботи
        }
    }
}
