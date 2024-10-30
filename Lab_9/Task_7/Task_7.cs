using System;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_7 : Form
    {
        public Task_7()
        {
            InitializeComponent();
            // Обробка події Click кнопки
            buttonCalculate.Click += (s, e) => CalculateAndDisplayResult();
        }

        private void CalculateAndDisplayResult()
        {
            int quantity;
            // Перевірка на коректність введення
            if (int.TryParse(textBoxQuantity.Text, out quantity) && quantity > 0)
            {
                double price = CalculatePrice(quantity);
                labelResult.Text = "Загальна вартість: " + price + " грн"; // Відображення результату
            }
            else
            {
                labelResult.Text = "Введіть коректну кількість осіб"; // Повідомлення про помилку
            }
        }

        private double CalculatePrice(int quantity)
        {
            double basePrice = 0;
            // Визначення ціни за типом туру
            if (radioButton1.Checked)
                basePrice = 550;  // Економ тур
            else if (radioButton2.Checked)
                basePrice = 1100; // Стандарт тур
            else if (radioButton3.Checked)
                basePrice = 2500; // Преміум тур

            return basePrice * quantity; // Повернення загальної вартості
        }
    }
}
