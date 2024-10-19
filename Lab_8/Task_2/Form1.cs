using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task_02
{
    public partial class Form1 : Form
    {
        private Font originalFont; // Зберігання ориг. шрифту
        private RadioButton[] cityRadioButtons; // Масив радіокнопок для міст
        private RadioButton[] transportRadioButtons; // Масив радіокнопок для транспорту

        public Form1()
        {
            InitializeComponent();
            // Встановлення вибір за замовчуванням
            radioButtonKharkiv.Checked = true;
            radioButtonTrain.Checked = true;

            // Зберігання оригінального шрифту
            originalFont = radioButtonKharkiv.Font;

            // Ініціалізпція масиву радіокнопок
            cityRadioButtons = new[] { radioButtonKharkiv, radioButtonKyiv, radioButtonOdesa, radioButtonZaporizhzhia };
            transportRadioButtons = new[] { radioButtonBus, radioButtonTrain, radioButtonPlane };
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            // Отримання вибраного міста та транспорту
            string selectedCity = GetSelectedRadioButtonText(cityRadioButtons);
            string selectedTransport = GetSelectedRadioButtonText(transportRadioButtons);
            MessageBox.Show($"Ви вибрали місто: {selectedCity} та транспорт: {selectedTransport}", "Вибір");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Повертання вибору до початкового стану
            radioButtonKharkiv.Checked = true;
            radioButtonTrain.Checked = true;

            // Відновлення оригінального шрифту для всіх радіокнопок
            ResetFonts(cityRadioButtons);
            ResetFonts(transportRadioButtons);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // Змінення стилю тексту для вибраних радіокнопок
            SetBoldItalicUnderline(cityRadioButtons);
            SetBoldItalicUnderline(transportRadioButtons);
        }

        private string GetSelectedRadioButtonText(RadioButton[] radioButtons)
        {
            // Повертаннея тексту вибраної радіокнопки
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty; // Якщо нічого не вибрано
        }

        private void ResetFonts(RadioButton[] radioButtons)
        {
            // Відновлення оригінального шрифту для радіокнопок
            foreach (var radioButton in radioButtons)
            {
                radioButton.Font = originalFont;
            }
        }

        private void SetBoldItalicUnderline(RadioButton[] radioButtons)
        {
            // Змінення стилю тексту для вибраних радіокнопок
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    radioButton.Font = new Font(originalFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
            }
        }
    }
}
