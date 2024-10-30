using System;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_9 : Form
    {
        public Task_9()
        {
            InitializeComponent(); 
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(textBoxQuantity.Text, out quantity) && quantity > 0)
            {
                double price = CalculatePrice(quantity); // Обчислення ціни
                labelResult.Text = "Загальна вартість: " + price + " грн"; // Виведення результату
            }
            else
            {
                labelResult.Text = "Введіть коректну кількість осіб"; // Помилка
            }
        }

        private double CalculatePrice(int quantity)
        {
            double basePrice = 0;
            switch (comboBoxTourType.SelectedIndex) // Вибір туру
            {
                case 0: // Економ
                    basePrice = 550;
                    break;
                case 1: // Стандарт
                    basePrice = 1100;
                    break;
                case 2: // Преміум
                    basePrice = 2500;
                    break;
            }

            return basePrice * quantity; // Повернення вартості
        }
    }
}
