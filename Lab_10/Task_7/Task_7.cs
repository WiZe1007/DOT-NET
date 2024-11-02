using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_7 : Form
    {
        public Task_7()
        {
            InitializeComponent();
            UpdateDateTimeLabel();  // Оновлення дати і часу
            UpdateTextLabel("");    // Ініціалізація тексту
        }

        // Оновлення дати і часу
        private void UpdateDateTimeLabel()
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Формат дати
        }

        // Текст у зворотному порядку з регістром
        private void UpdateTextLabel(string inputText)
        {
            var reversedText = new string(inputText
                .Select(c => char.IsLetter(c)
                    ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) // Зміна регістру
                    : c) // Інші символи
                .Reverse() // Реверс
                .ToArray());

            toolStripStatusLabel2.Text = reversedText; // Оновлення тексту
        }

        // Обробка зміни тексту
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();                // Оновлення дати і часу
            UpdateTextLabel(textBox1.Text);       // Оновлення тексту
        }
    }
}
