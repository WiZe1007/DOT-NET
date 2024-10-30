using System;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_8 : Form
    {
        public Task_8()
        {
            InitializeComponent(); 
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            // Перевірка на коректної ількості
            if (int.TryParse(textBoxQuantity.Text, out quantity) && quantity > 0)
            {
                double totalPrice = CalculatePrice(quantity, out double monthlyPayment);
                string resultMessage;

                // Формування повідомлення для рез.
                if (radioButtonRetail.Checked)
                {
                    resultMessage = $"Загальна вартість: {totalPrice} грн\nЩомісячна оплата: {monthlyPayment} грн/міс.";
                }
                else
                {
                    resultMessage = $"Загальна вартість: {totalPrice} грн";
                }

                labelResult.Text = resultMessage; // Виведення результату
            }
            else
            {
                labelResult.Text = "Введіть коректну кількість осіб"; // Повідомлення про помилку
            }
        }

        private double CalculatePrice(int quantity, out double monthlyPayment)
        {
            // Визначення ціни за особу на основі вибраного туру
            double pricePerPerson = 0;
            if (radioButton1.Checked)
            {
                pricePerPerson = 550; // Економ
            }
            else if (radioButton2.Checked)
            {
                pricePerPerson = 1100; // Стандарт
            }
            else if (radioButton3.Checked)
            {
                pricePerPerson = 2500; // Преміум
            }

            // Обчислення загальної вартості
            double totalCost = quantity * pricePerPerson;

            // Обробка різних типів цін
            if (radioButtonRetail.Checked)
            {
                totalCost *= 1.2; // Роздрібна ціна (+20%)
                monthlyPayment = totalCost / 12; // Щомісячна оплата
            }
            else if (radioButtonWholesale.Checked)
            {
                totalCost *= 0.8; // Оптова ціна (-20%)
                monthlyPayment = 0; // Без щомісячної оплати
            }
            else
            {
                monthlyPayment = 0; // Немає щомісячної оплати
            }

            return totalCost; // Повернення загальної вартості
        }
    }
}
