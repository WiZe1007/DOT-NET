using System; // Підключення простору імен для роботи з базовими класами .NET
using System.Windows.Forms; // Підключення простору імен для роботи з формами Windows Forms

namespace Task_4 // Оголошення простору імен для програми
{
    public partial class Form1 : Form // Оголошення класу Form1, який є частиною форми
    {
        public Form1() // Конструктор класу
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            // Встановлення вибору за замовчанням для радіокнопок
            radioButtonKharkiv.Checked = true; // Вибір Харкова як міста за замовчанням
            radioButtonTrain.Checked = true; // Вибір потяга як транспорту за замовчанням
        }

        private void buttonSelect_Click(object sender, EventArgs e) // Обробник події натискання кнопки "Вибрати"
        {
            string selectedCity = ""; // Змінна для збереження вибраного міста
            string selectedTransport = ""; // Змінна для збереження вибраного транспорту

            // Перевірка, яке місто було вибрано за допомогою радіокнопок
            if (radioButtonKharkiv.Checked)
                selectedCity = radioButtonKharkiv.Text; // Якщо вибрано Харків
            else if (radioButtonKyiv.Checked)
                selectedCity = radioButtonKyiv.Text; // Якщо вибрано Київ
            else if (radioButtonOdesa.Checked)
                selectedCity = radioButtonOdesa.Text; // Якщо вибрано Одесу
            else if (radioButtonZaporizhzhia.Checked)
                selectedCity = radioButtonZaporizhzhia.Text; // Якщо вибрано Запоріжжя

            // Перевірка, який транспорт був вибраний за допомогою радіокнопок
            if (radioButtonBus.Checked)
                selectedTransport = radioButtonBus.Text; // Якщо вибрано автобус
            else if (radioButtonTrain.Checked)
                selectedTransport = radioButtonTrain.Text; // Якщо вибрано потяг
            else if (radioButtonPlane.Checked)
                selectedTransport = radioButtonPlane.Text; // Якщо вибрано літак

            // Виведення повідомлення з вибраними містом і транспортом
            MessageBox.Show($"Ви вибрали місто: {selectedCity} та транспорт: {selectedTransport}", "Вибір");
        }

        private void buttonCancel_Click(object sender, EventArgs e) // Обробник події натискання кнопки "Скасувати"
        {
            this.Close(); // Закриття форми
        }
    }
}
