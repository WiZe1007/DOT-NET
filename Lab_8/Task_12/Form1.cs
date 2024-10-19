using System;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // Таймер для видимості кнопки
        private bool isButtonVisible; // Стан видимості кнопки

        public Form1()
        {
            InitializeComponent(); 
            InitializeTimer(); // Налаштування таймера
            isButtonVisible = true; 
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer(); // Створення таймера
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick; // Обробка події Tick
            // Таймер не запускається автоматично
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Перемикаємо видимість кнопки
            isButtonVisible = !isButtonVisible;
            button1.Visible = isButtonVisible; // Оновлюємо видимість кнопки
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Interval = (int)intervalNumericUpDown.Value; // Оновлення інтервалу
            timer.Start(); // Запуск таймера
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Зупинка таймера
        }
    }
}
