using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab_11_Task_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string configFile = Path.Combine(Application.StartupPath, "default.cfg");
            LoadConfiguration(configFile);
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

        public void LoadConfiguration(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        // Десеріалізація конфігурації
                        string json = reader.ReadToEnd();
                        Configuration config = JsonConvert.DeserializeObject<Configuration>(json);

                        // Застосування параметрів
                        ApplyConfiguration(labelTitle, config.LabelTitleForeColorArgb, config.LabelTitleFontName, config.LabelTitleFontSize, config.LabelTitleFontStyle);
                        ApplyConfiguration(groupBoxContactInfo, config.GroupBoxContactInfoForeColorArgb, config.GroupBoxContactInfoFontName, config.GroupBoxContactInfoFontSize, config.GroupBoxContactInfoFontStyle);
                        ApplyConfiguration(groupBoxPersonalInfo, config.GroupBoxPersonalInfoForeColorArgb, config.GroupBoxPersonalInfoFontName, config.GroupBoxPersonalInfoFontSize, config.GroupBoxPersonalInfoFontStyle);
                        ApplyConfiguration(groupBoxEvaluation, config.GroupBoxEvaluationForeColorArgb, config.GroupBoxEvaluationFontName, config.GroupBoxEvaluationFontSize, config.GroupBoxEvaluationFontStyle);
                        ApplyConfiguration(buttonSubmit, config.ButtonSubmitForeColorArgb, config.ButtonSubmitFontName, config.ButtonSubmitFontSize, config.ButtonSubmitFontStyle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні конфігурації: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyConfiguration(Control control, int foreColorArgb, string fontName, float fontSize, FontStyle fontStyle)
        {
            control.ForeColor = Color.FromArgb(foreColorArgb);
            control.Font = new Font(fontName, fontSize, fontStyle);
        }
    }
}
