using System; 
using System.Windows.Forms; 

namespace Task_04 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent(); 
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // Обробник натискання кнопки "Submit"
        {
            // Перевірка на заповненість полів
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                comboBoxAge.SelectedIndex == -1 ||
                comboBoxCuisine.SelectedIndex == -1 ||
                (!radioButtonReason1.Checked && !radioButtonReason2.Checked) ||
                (!radioButtonYes.Checked && !radioButtonNo.Checked))
            {
                MessageBox.Show("Будь ласка, заповніть усі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Завершення
            }

            // Збір даних
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            DateTime visitDate = dateTimePickerVisit.Value;
            string age = comboBoxAge.SelectedItem?.ToString();
            string cuisine = comboBoxCuisine.SelectedItem?.ToString();
            string dishes = textBoxDishes.Text;

            // Вибір причини та рекомендації
            string reason = radioButtonReason1.Checked ? radioButtonReason1.Text : radioButtonReason2.Text;
            string recommend = radioButtonYes.Checked ? "Так" : "Ні";

            // Формування повідомлення
            string message = $"Ім'я: {name}\nПошта: {email}\nТелефон: {phone}\nДата відвідування: {visitDate.ToShortDateString()}\n" +
                             $"Вік: {age}\nУлюблена кухня: {cuisine}\nСтрави: {dishes}\nЧому обрали наш ресторан: {reason}\n" +
                             $"Чи порекомендуєте ресторан: {recommend}";

            MessageBox.Show(message, "Інформація про відвідувача"); // Виведення інформації
        }

        private void ButtonClear_Click(object sender, EventArgs e) // Обробник натискання кнопки "Clear"
        {
            // Очищення полів
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            dateTimePickerVisit.Value = DateTime.Now;
            comboBoxAge.SelectedIndex = -1;
            comboBoxCuisine.SelectedIndex = -1;
            textBoxDishes.Clear();

            // Очищення радіо-кнопок
            radioButtonReason1.Checked = false;
            radioButtonReason2.Checked = false;
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
        }
    }
}
