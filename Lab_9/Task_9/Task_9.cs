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
            if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity > 0)
            {
                double price = CalculatePrice(quantity); // Обчислення ціни
                labelResult.Text = $"Загальна вартість: {price} грн"; // Виведення результату
            }
            else
            {
                labelResult.Text = "Введіть коректну кількість осіб"; // Помилка
            }
        }

        private double CalculatePrice(int quantity) =>
            (comboBoxTourType.SelectedIndex switch // Вибір туру
            {
                0 => 550,    // Економ
                1 => 1100,   // Стандарт
                2 => 2500,   // Преміум
                _ => 0       // За замовчуванням
            }) * quantity; // Повернення вартості
    }
}
