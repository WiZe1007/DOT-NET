using System;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_5 : Form
    {
        private const decimal BasePrice = 2000m; // Основна ціна
        private const decimal DiscountRate = 0.1m; // Ставка знижки

        public Task_5()
        {
            InitializeComponent(); 
        }

        private void calculateButton_Click()
        {
            decimal additionalPrice = 0m; // Додаткова ціна

            // Додавання вартості вибраних послуг
            if (excursionCheckBox.Checked) additionalPrice += 500; // Екскурсії
            if (mealsCheckBox.Checked) additionalPrice += 300; // Харчування
            if (insuranceCheckBox.Checked) additionalPrice += 150; // Страхування
            if (transferCheckBox.Checked) additionalPrice += 200; // Трансфер

            // Обчислення знижки та заг. ціни
            decimal discount = additionalPrice * DiscountRate; // Знижка
            decimal totalPrice = BasePrice + additionalPrice - discount; // Загальна ціна

            // Відображаємо результати
            additionalLabel.Text = $"В т.ч. дод. послуги: {additionalPrice} грн"; // Додаткові послуги
            discountLabel.Text = $"Знижка на дод. послуги (10%): {discount} грн"; // Знижка
            totalLabel.Text = $"Разом: {totalPrice} грн"; // Загальна сума
        }
    }
}
