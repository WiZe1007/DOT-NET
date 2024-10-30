using System;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_6 : Form
    {
        private const decimal BasePrice = 2000m; // Базова ціна
        private const decimal DiscountRate = 0.1m; // Ставка знижки
        private const decimal UsdExchangeRate = 41.44m; // Курс UAH до USD
        private const decimal EurExchangeRate = 44.76m; // Курс UAH до EUR

        public Task_6()
        {
            InitializeComponent(); 
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal additionalPrice = 0m; // Додаткова ціна

            // Додаткові послуги
            if (excursionCheckBox.Checked) additionalPrice += 500; // Екскурсії
            if (mealsCheckBox.Checked) additionalPrice += 300; // Харчування
            if (insuranceCheckBox.Checked) additionalPrice += 150; // Страхування
            if (transferCheckBox.Checked) additionalPrice += 200; // Трансфер

            decimal discount = additionalPrice * DiscountRate; // Розрахунок знижки
            decimal totalPrice = BasePrice + additionalPrice - discount; // Загальна ціна

            // Виведення результатів
            additionalLabel.Text = $"В т.ч. дод. послуги: {additionalPrice} грн";
            discountLabel.Text = $"Знижка на дод. послуги (10%): {discount} грн";
            totalLabel.Text = $"Разом: {totalPrice} грн";

            // Конвертація ціни
            string selectedCurrency = currencyComboBox.SelectedItem?.ToString();
            decimal convertedPrice = totalPrice; // За замовчуванням - гривні

            if (selectedCurrency == "Долар (USD)")
            {
                convertedPrice /= UsdExchangeRate; // Конвертація в USD
            }
            else if (selectedCurrency == "Євро (EUR)")
            {
                convertedPrice /= EurExchangeRate; // Конвертація в EUR
            }

            convertedPriceLabel.Text = $"Ціна в {selectedCurrency}: {convertedPrice:F2}"; // Виведення конвертованої ціни
        }
    }
}
