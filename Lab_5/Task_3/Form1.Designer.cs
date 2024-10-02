namespace test // Оголошення простору імен 'test'
{
    partial class Form1 // Оголошення часткового класу 'Form1'
    {
        private System.ComponentModel.IContainer components = null; // Змінна для зберігання компонентів форми

        /// <summary>
        /// Очищення всіх ресурсів, що використовуються.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси повинні бути видалені; інакше - false.</param>
        protected override void Dispose(bool disposing) // Метод для очищення ресурсів
        {
            if (disposing && (components != null)) // Якщо 'disposing' дорівнює true та компоненти не є null
            {
                components.Dispose(); // Очищення керованих компонентів
            }
            base.Dispose(disposing); // Виклик базового методу Dispose для очищення некерованих ресурсів
        }

        /// <summary>
        /// Ініціалізація компонентів форми.
        /// </summary>
        private void InitializeComponent() // Метод для ініціалізації компонентів форми
        {
            this.SuspendLayout(); // Тимчасово зупиняє автоматичне розташування елементів форми
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Встановлення фактору масштабування для елементів форми
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Вибір режиму масштабування шрифту
            this.ClientSize = new System.Drawing.Size(400, 300); // Встановлення розмірів форми
            this.Text = "Task_3"; // Встановлення заголовку форми
            this.Load += new System.EventHandler(this.Form_Load); // Додавання обробника події завантаження форми
            this.ResumeLayout(false); // Відновлення автоматичного розташування елементів
        }
    }
}

