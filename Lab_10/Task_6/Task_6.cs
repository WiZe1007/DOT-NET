using System;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_6 : Form
    {
        private int minutes = 0; // Хвилини
        private int seconds = 0; // Секунди
        private bool isRunning = false; // Статус таймера

        private System.Windows.Forms.Timer visibilityTimer; // Таймер для перемикання видимості кнопки

        public Task_6()
        {
            InitializeComponent();

            // Ініціалізація таймера видимості
            visibilityTimer = new System.Windows.Forms.Timer();
            visibilityTimer.Interval = 5000; // Інтервал 5 секунд
            visibilityTimer.Tick += VisibilityTimer_Tick;
        }

        // Обробка натискання кнопки старт/стоп
        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop(); // Зупинка таймера
                visibilityTimer.Stop(); // Зупинка таймера видимості
                buttonToggle.Text = "Старт"; // Зміна тексту кнопки
                buttonToggle.Visible = true; // Зробити кнопку видимою
            }
            else
            {
                // Отримання значень хвилин і секунд з numericUpDown
                minutes = (int)numericUpDown1.Value;
                seconds = (int)numericUpDown2.Value;

                // Оновлення відображення часу
                UpdateTimeDisplay();

                timer1.Start(); // Запуск таймера
                visibilityTimer.Start(); // Запуск таймера видимості
                buttonToggle.Text = "Стоп"; // Зміна тексту кнопки
            }
            isRunning = !isRunning; // Перемикання статусу
        }

        // Обробка події таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Зменшення секунд
            if (seconds == 0)
            {
                if (minutes == 0)
                {
                    timer1.Stop(); // Зупинка таймера
                    visibilityTimer.Stop(); // Зупинка таймера видимості
                    buttonToggle.Text = "Старт"; // Зміна тексту кнопки
                    buttonToggle.Visible = true; // Зробити кнопку видимою
                    isRunning = false; // Встановлення статусу
                    return;
                }
                else
                {
                    minutes--; // Зменшення хвилин
                    seconds = 59; // Скидання секунд
                }
            }
            else
            {
                seconds--; // Зменшення секунд
            }

            // Оновлення відображення часу
            UpdateTimeDisplay();
        }

        // Обробка події таймера видимості
        private void VisibilityTimer_Tick(object sender, EventArgs e)
        {
            buttonToggle.Visible = !buttonToggle.Visible; // Перемикання видимості кнопки
        }

        // Оновлення відображення часу в мітці
        private void UpdateTimeDisplay()
        {
            label1.Text = $"{minutes:D2}:{seconds:D2}"; // Формат часу
        }
    }
}
