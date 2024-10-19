using System;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // Таймер
        private bool isButtonVisible; // Видимість кнопки

        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
            InitializeTimer(); // Налаштування 
            isButtonVisible = true; // Кнопка спочатку видима
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer(); // Створення таймера
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick; // Обробник події Tick
            timer.Start(); // Запуск таймера
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Перемикання видимості кнопки
            isButtonVisible = !isButtonVisible;
            button1.Visible = isButtonVisible;
        }
    }
}
