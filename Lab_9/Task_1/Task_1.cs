using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_1 : Form
    {
        private const decimal ExchangeRate = 11.79m; // Курс обміну

        public Task_1()
        {
            InitializeComponent();
            button1.Enabled = false; // Кнопка спочатку неактивна

            // Підписка на події
            textBox1.TextChanged += (s, e) => TextBox1_TextChanged();
            button1.Click += (s, e) => Button1_Click();
        }

        private void TextBox1_TextChanged()
        {
            // Дозволяє вводити тільки цифри
            string input = textBox1.Text;
            if (!decimal.TryParse(input, out _))
            {
                textBox1.Text = string.Concat(input.Where(char.IsDigit)); // Обрізає нечислові
                textBox1.SelectionStart = textBox1.Text.Length; // Встановлює курсор
            }

            // Активує кнопку OK
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void Button1_Click()
        {
            // Конвертація значення
            if (decimal.TryParse(textBox1.Text, out decimal amountUah))
            {
                decimal result = amountUah * ExchangeRate; // Обчислення
                label2.Text = $"{amountUah} грн = {result:F2} Теньге"; // Відображення
            }
            else
            {
                label2.Text = "Некоректне значення."; // Помилка
            }
        }
    }
}
