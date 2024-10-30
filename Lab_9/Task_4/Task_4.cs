using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_9
{
    public partial class Task_4 : Form
    {
        private const decimal KmToPunkt = 2835447.2m; // Коефіцієнт: км до пунктів
        private const decimal PunktToKm = 1 / KmToPunkt; // Коефіцієнт: пункти до км

        public Task_4()
        {
            InitializeComponent();
            button1.Enabled = false; // Кнопка спочатку неактивна
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Дозволяє вводити лише цифри
            string input = textBox1.Text;
            if (!decimal.TryParse(input, out _))
            {
                textBox1.Text = string.Concat(input.Where(char.IsDigit)); // Фільтрує нецифрові символи
                textBox1.SelectionStart = textBox1.Text.Length; // Переміщує курсор
            }

            // Активує кнопку, якщо поле не пусте
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримує вибране значення для конвертації
            string selectedConversion = conversionDirectionComboBox.SelectedItem.ToString();

            if (decimal.TryParse(textBox1.Text, out decimal inputDistance))
            {
                decimal result;
                if (selectedConversion == "Кілометри в пункти")
                {
                    result = inputDistance * KmToPunkt; // Конвертація км в пункти
                    resultLabel.Text = $"{inputDistance} км = {result:F2} пункти";
                }
                else if (selectedConversion == "Пункти в кілометри")
                {
                    result = inputDistance * PunktToKm; // Конвертація пунктів в км
                    resultLabel.Text = $"{inputDistance} пункти = {result:F2} км";
                }
            }
            else
            {
                resultLabel.Text = "Некоректне значення."; // Повідомлення про помилку
            }
        }
    }
}
