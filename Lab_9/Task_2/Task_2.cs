using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_2 : Form
    {
        private const decimal ExchangeRate = 11.79m; // Курс гривня - теньге

        public Task_2()
        {
            InitializeComponent();
            button1.Enabled = false; // Неактивна кнопка
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Тільки цифри у текстовому полі
            string input = textBox1.Text;
            if (!decimal.TryParse(input, out _))
            {
                textBox1.Text = string.Concat(input.Where(char.IsDigit)); // Фільтрація
                textBox1.SelectionStart = textBox1.Text.Length; // Курсор в кінець
            }

            // Активувати кнопку OK
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Конвертація валюти
            if (decimal.TryParse(textBox1.Text, out decimal amount))
            {
                if (radioButtonToKZT.Checked) // Грн в Теньге
                {
                    decimal result = amount * ExchangeRate; // Розрахунок
                    label2.Text = $"{amount} грн = {result:F2} теньге"; // Результат
                }
                else if (radioButtonToUAH.Checked) // Теньге в Грн
                {
                    decimal result = amount / ExchangeRate; // Розрахунок
                    label2.Text = $"{amount} теньге = {result:F2} грн"; // Результат
                }
            }
            else
            {
                label2.Text = "Некоректне значення."; // Помилка
            }
        }
    }
}
