using System;
using System.Windows.Forms;

namespace Lab_11_Task_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // Обробник натискання кнопки Submit
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
            var message = string.Join("\n", new[]
            {
                $"Ім'я: {textBoxName.Text}",
                $"Пошта: {textBoxEmail.Text}",
                $"Телефон: {textBoxPhone.Text}",
                $"Дата відвідування: {dateTimePickerVisit.Value.ToShortDateString()}",
                $"Вік: {comboBoxAge.SelectedItem}",
                $"Улюблена кухня: {comboBoxCuisine.SelectedItem}",
                $"Страви: {textBoxDishes.Text}",
                $"Чому обрали наш ресторан: {(radioButtonReason1.Checked ? radioButtonReason1.Text : radioButtonReason2.Text)}",
                $"Чи порекомендуєте ресторан: {(radioButtonYes.Checked ? "Так" : "Ні")}"
            });

            // Виведення повідомлення
            MessageBox.Show(message, "Інформація про відвідувача");
        }

        private void ButtonClear_Click(object sender, EventArgs e) // Обробник натискання кнопки Clear
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

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            // Відкриття форми налаштувань
            ConfigForm configForm = new ConfigForm(this);
            configForm.Show();
        }
    }
}
