using System; // Підключення простору імен System, що містить основні класи .NET
using System.Windows.Forms; // Підключення простору імен для роботи з формами Windows

namespace Task__6 // Оголошення простору імен Task__6
{
    public partial class Form1 : Form // Оголошення класу Form1, який наслідує від класу Form
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів форми
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // Обробник події натискання кнопки "Submit"
        {
            // Перевірка на заповненість полів
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || // Перевірка, чи поле ім'я не пусте
                string.IsNullOrWhiteSpace(textBoxEmail.Text) || // Перевірка, чи поле email не пусте
                string.IsNullOrWhiteSpace(textBoxPhone.Text) || // Перевірка, чи поле телефону не пусте
                comboBoxAge.SelectedIndex == -1 || // Перевірка, чи вибрано вік
                comboBoxCuisine.SelectedIndex == -1 || // Перевірка, чи вибрано кухню
                (!radioButtonReason1.Checked && !radioButtonReason2.Checked) || // Перевірка, чи вибрано причину
                (!radioButtonYes.Checked && !radioButtonNo.Checked)) // Перевірка, чи вибрано відповідь на запитання
            {
                // Виведення повідомлення про помилку, якщо не всі поля заповнені
                MessageBox.Show("Будь ласка, заповніть усі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Завершення виконання методу, якщо є помилка
            }

            // Збір даних з полів форми
            string name = textBoxName.Text; // Отримання імені з текстового поля
            string email = textBoxEmail.Text; // Отримання email з текстового поля
            string phone = textBoxPhone.Text; // Отримання телефону з текстового поля
            DateTime visitDate = dateTimePickerVisit.Value; // Отримання дати відвідування з елемента DateTimePicker
            string age = comboBoxAge.SelectedItem?.ToString(); // Отримання віку з ComboBox, з перевіркою на null
            string cuisine = comboBoxCuisine.SelectedItem?.ToString(); // Отримання кухні з ComboBox, з перевіркою на null
            string dishes = textBoxDishes.Text; // Отримання страв з текстового поля

            // Вибір причини, чому обрали ресторан
            string reason = radioButtonReason1.Checked ? radioButtonReason1.Text : radioButtonReason2.Text; // Визначення причини в залежності від вибору радіо-кнопок

            // Чи буде рекомендувати ресторан
            string recommend = radioButtonYes.Checked ? "Так" : "Ні"; // Визначення відповіді на запитання про рекомендацію

            // Формування повідомлення з усіма зібраними даними
            string message = $"Ім'я: {name}\nПошта: {email}\nТелефон: {phone}\nДата відвідування: {visitDate.ToShortDateString()}\n" +
                             $"Вік: {age}\nУлюблена кухня: {cuisine}\nСтрави: {dishes}\nЧому обрали наш ресторан: {reason}\n" +
                             $"Чи порекомендуєте ресторан: {recommend}";

            // Виведення повідомлення в діалоговому вікні
            MessageBox.Show(message, "Інформація про відвідувача"); // Показ повідомлення з інформацією
        }

        private void ButtonClear_Click(object sender, EventArgs e) // Обробник події натискання кнопки "Clear"
        {
            // Очищення полів форми
            textBoxName.Clear(); // Очищення текстового поля з іменем
            textBoxEmail.Clear(); // Очищення текстового поля з email
            textBoxPhone.Clear(); // Очищення текстового поля з телефоном
            dateTimePickerVisit.Value = DateTime.Now; // Скидання дати відвідування на сьогоднішню дату
            comboBoxAge.SelectedIndex = -1; // Скидання вибору віку
            comboBoxCuisine.SelectedIndex = -1; // Скидання вибору кухні
            textBoxDishes.Clear(); // Очищення текстового поля з стравами

            // Очищення радіо-кнопок
            radioButtonReason1.Checked = false; // Зняття вибору з першої радіо-кнопки
            radioButtonReason2.Checked = false; // Зняття вибору з другої радіо-кнопки
            radioButtonYes.Checked = false; // Зняття вибору з кнопки "Так"
            radioButtonNo.Checked = false; // Зняття вибору з кнопки "Ні"
        }
    }
}
