using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_3 : Form
    {
        private const decimal KmToPunkt = 2835447.2m; // Коеф. конвертації

        public Task_3()
        {
            InitializeComponent();
            button1.Enabled = false; // Кнопка неактивна
        }

        private void TextBox1_TextChanged()
        {
            // Дозволити лише цифри
            string input = textBox1.Text;
            if (!decimal.TryParse(input, out _))
            {
                textBox1.Text = string.Concat(input.Where(char.IsDigit)); // Фільтрація
                textBox1.SelectionStart = textBox1.Text.Length; // Курсор в кінець
            }

            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text); // Активувати кнопку
        }

        private void Button1_Click()
        {
            // Конвертація км в пункти
            if (decimal.TryParse(textBox1.Text, out decimal kilometers))
            {
                decimal points = kilometers * KmToPunkt; // Обчислення
                resultLabel.Text = $"{kilometers} км = {points:F2} пункти"; // Вивід
            }
            else
            {
                resultLabel.Text = "Некоректне значення."; // Помилка
            }
        }
    }
}
