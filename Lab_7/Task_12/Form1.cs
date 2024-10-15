using System;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів

            // Додавання міст до ComboBox і ListBox
            comboBox1.Items.AddRange(new string[] {
                "Каїр",
                "Александрія",
                "Гіза",
                "Луксор",
                "Асуан"
            });
            listBox1.Items.AddRange(new string[] {
                "Каїр",
                "Александрія",
                "Гіза",
                "Луксор",
                "Асуан"
            });
        }

        // Обробка вибору в ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримання вибраного міста
            string selectedCity = comboBox1.SelectedItem.ToString();
            // Виведення повідомлення
            MessageBox.Show("Ви вибрали місто: " + selectedCity);
        }

        // Обробка 2-го кліку на ListBox
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Перевірка вибору
            if (listBox1.SelectedItem != null)
            {
                // Отримання вибраного міста
                string selectedCity = listBox1.SelectedItem.ToString();
                // Виведення повідомлення
                MessageBox.Show("Ви вибрали місто: " + selectedCity);
            }
        }
    }
}
