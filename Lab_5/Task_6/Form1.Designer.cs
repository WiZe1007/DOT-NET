namespace Task_6
{
    partial class Form1 // Оголошення часткового класу Form1, що може бути визначений у кількох файлах.
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Змінна для зберігання компонентів форми.

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) // Метод для очищення ресурсів, пов'язаних з формою.
        {
            if (disposing && (components != null)) // Перевірка, чи потрібно звільнити керовані ресурси.
            {
                components.Dispose(); // Вивільнення ресурсів компонентів.
            }
            base.Dispose(disposing); // Виклик базового класу для звільнення ресурсів.
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора - не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() // Метод, що ініціалізує компоненти форми.
        {
            this.SuspendLayout(); // Зупиняє оновлення компонента, поки проводяться зміни.
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлення масштабних параметрів форми.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Встановлення режиму масштабування на основі шрифтів.
            this.ClientSize = new System.Drawing.Size(800, 450); // Встановлення розміру клієнтської області форми.
            this.Name = "Form1"; // Задання назви форми.
            this.Text = "Form1"; // Встановлення заголовка форми.
            this.Load += new System.EventHandler(this.Form1_Load); // Додавання обробника події завантаження форми.
            this.ResumeLayout(false); // Поновлення оновлення компонента, завершивши зміни.

        }

        #endregion
    }
}

