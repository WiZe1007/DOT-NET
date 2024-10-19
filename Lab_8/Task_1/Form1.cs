using System;
using System.Drawing; // Для роботи зі шрифтами
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        // Конструктор форми
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
        }

        // Обробник події "Відіслати"
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // Жирний, курсивний, підкреслений шрифт
            FontStyle fontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
            textBoxName.Font = new Font(textBoxName.Font, fontStyle); // Шрифт імені
            textBoxPhone.Font = new Font(textBoxPhone.Font, fontStyle); // Шрифт для телефону
            textBoxEmail.Font = new Font(textBoxEmail.Font, fontStyle); // Шрифт для електронної пошти

            // Повідомлення про успішне відправлення
            MessageBox.Show("Дані відправлено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Обробник події "Скинути"
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // Очищення текстових полів
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();

            // Скидання дати до поточної
            dateTimePickerDOB.Value = DateTime.Now;

            // Відновлення стандартного шрифту
            textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular); // Шрифт для імені
            textBoxPhone.Font = new Font(textBoxPhone.Font, FontStyle.Regular); // Шрифт для телефону
            textBoxEmail.Font = new Font(textBoxEmail.Font, FontStyle.Regular); // Шрифт для електронної пошти
        }
    }
}
