using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_5 : Form
    {
        private int minutes = 0; // Хвилини
        private int seconds = 0; // Секунди
        private int toggleCounter = 0; // Лічильник для 5 секунд

        public Task_5()
        {
            InitializeComponent(); 
        }

        // Обробник таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++; // Збільшення секунд
            if (seconds == 60) // Якщо 60 секунд
            {
                seconds = 0; // Скидання секунд
                minutes++; // Збільшення хвилин
            }

            // Оновлення тексту міток
            label1.Text = minutes.ToString("D2"); // Формат для хвилин
            label3.Text = seconds.ToString("D2"); // Формат для секунд

            // Кожні 5 секунд перемикаємо видимість кнопок
            toggleCounter++;
            if (toggleCounter == 5)
            {
                buttonStart.Visible = !buttonStart.Visible; // Перемикання видимості
                buttonStop.Visible = !buttonStop.Visible;
                toggleCounter = 0; // Скидання лічильника
            }
        }

        // Обробник кнопки Старт
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start(); // Запуск таймера
        }

        // Обробник кнопки Стоп
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Зупинка таймера
        }
    }
}
