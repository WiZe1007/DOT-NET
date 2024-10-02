using System; // Підключення простору імен System для базових функцій і класів.

namespace test // Оголошення простору імен 'test', в якому містяться всі елементи класу.
{
    partial class Form1 // Часткове оголошення класу Form1, що успадковує властивості та методи форми.
    {
        // Оголошення компонента типу IContainer для керування ресурсами.
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення всіх ресурсів, що використовуються формою.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси повинні бути звільнені; false - якщо ні.</param>
        protected override void Dispose(bool disposing) // Перевизначення методу Dispose для очищення ресурсів.
        {
            if (disposing && (components != null)) // Якщо викликається звільнення ресурсів і компоненти не є null.
            {
                components.Dispose(); // Звільняємо керовані ресурси.
            }
            base.Dispose(disposing); // Виклик базового методу Dispose для звільнення некерованих ресурсів.
        }

        /// <summary>
        /// Метод для ініціалізації компонентів форми.
        /// </summary>
        private void InitializeComponent() // Метод, який відповідає за ініціалізацію компонентів форми.
        {
            this.SuspendLayout(); // Призупинення макетування для внесення змін.

            // 
            // Task_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Встановлення масштабування розмірів елементів інтерфейсу користувача.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Встановлення автоматичного масштабування відповідно до розміру шрифту.
            this.ClientSize = new System.Drawing.Size(400, 300); // Встановлення розмірів форми (ширина 400, висота 300).
            this.Text = "Task_4"; // Встановлення тексту заголовка форми.
            this.Load += new System.EventHandler(this.Form_Load); // Додавання обробника події для завантаження форми (Form_Load).
            
            this.ResumeLayout(false); // Відновлення макетування після внесення змін.
        }
    }
}

