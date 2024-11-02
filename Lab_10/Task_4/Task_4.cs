using System;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_4 : Form
    {
        public Task_4()
        {
            InitializeComponent(); // Ініціалізація компонентів
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитування та перетв. введених даних
                decimal loanAmount = decimal.Parse(txtAmount.Text);
                int termMonths = int.Parse(txtTerm.Text);
                decimal interestRate = decimal.Parse(txtInterestRate.Text) / 100;

                // Обчислення місячного платежу
                decimal monthlyInterest = interestRate / 12;
                decimal monthlyPayment = loanAmount * (monthlyInterest * (decimal)Math.Pow((double)(1 + monthlyInterest), termMonths)) /
                                         (decimal)(Math.Pow((double)(1 + monthlyInterest), termMonths) - 1);

                listViewSchedule.Items.Clear(); // Очищення списку

                decimal balance = loanAmount; // Початковий баланс

                for (int month = 1; month <= termMonths; month++)
                {
                    // Розрахунок процентів та основного платежу
                    decimal interest = balance * monthlyInterest;
                    decimal principal = monthlyPayment - interest;
                    balance -= principal; // Оновлення балансу

                    // Додавання даних до списку
                    ListViewItem item = new ListViewItem(month.ToString());
                    item.SubItems.Add(balance.ToString("F2"));
                    item.SubItems.Add(interest.ToString("F2"));
                    item.SubItems.Add(monthlyPayment.ToString("F2"));
                    listViewSchedule.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Обробка помилок введення
                MessageBox.Show("Помилка введення даних. Переконайтеся, що введені коректні значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
