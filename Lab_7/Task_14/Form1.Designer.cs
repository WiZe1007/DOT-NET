namespace Task_14
{
    partial class Form1
    {
        /// <summary>
        /// Ініціалізація компонентів форми.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout(); // Підготовка

            // Налаштування форми
            this.ClientSize = new System.Drawing.Size(800, 450); // Розмір
            this.Name = "Form1"; // Назва
            this.Text = "Task 14"; // Заголовок
            this.Load += new System.EventHandler(this.Form1_Load); // Обробник події

            this.ResumeLayout(false); // Завершення
        }
    }
}
