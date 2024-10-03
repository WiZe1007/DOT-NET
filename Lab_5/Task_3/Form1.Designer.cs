namespace task_03 // Оголошення простору імен для проекту.
{
    partial class Form1 // Оголошення часткового класу Form1.
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null; // Ініціалізація контейнера для компонентів форми.

        /// <summary>
        /// Очищення всіх використовуваних ресурсів.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси слід утилізувати; інакше false.</param>
        protected override void Dispose(bool disposing) // Перевизначення методу Dispose для очищення ресурсів.
        {
            if (disposing && (components != null)) // Перевірка, чи потрібно очищати керовані ресурси.
            {
                components.Dispose(); // Виклик методу Dispose для очищення компонентів.
            }
            base.Dispose(disposing); // Виклик базового методу Dispose.
        }

        #region Код, автоматично створений дизайнером форм Windows

        /// <summary>
        /// Метод, необхідний для підтримки конструктора - не редагуйте
        /// вміст цього методу з редактором коду.
        /// </summary>
        private void InitializeComponent() // Метод для ініціалізації компонентів форми.
        {
            this.textBox1 = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля 1.
            this.textBox2 = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля 2.
            this.textBox3 = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля 3.
            this.SuspendLayout(); // Тимчасове призупинення оновлення елементів форми.

            // textBox1
            this.textBox1.BackColor = System.Drawing.Color.Green; // Встановлення фону текстового поля 1.
            this.textBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic); // Налаштування шрифту текстового поля 1.
            this.textBox1.ForeColor = System.Drawing.Color.Pink; // Встановлення кольору тексту текстового поля 1.
            this.textBox1.Location = new System.Drawing.Point(12, 12);  // Встановлення позиції текстового поля 1 на формі.
            this.textBox1.ReadOnly = true; // Встановлення текстового поля 1 у режим лише для читання.
            this.textBox1.Size = new System.Drawing.Size(360, 32); // Встановлення розміру текстового поля 1.
            this.textBox1.Text = "Перший рядок"; // Встановлення тексту текстового поля 1.
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left; // Вирівнювання тексту текстового поля 1.

            // textBox2
            this.textBox2.BackColor = System.Drawing.Color.Red; // Встановлення фону текстового поля 2.
            this.textBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline); // Налаштування шрифту текстового поля 2.
            this.textBox2.ForeColor = System.Drawing.Color.Blue; // Встановлення кольору тексту текстового поля 2.
            this.textBox2.Location = new System.Drawing.Point(12, 50); // Встановлення позиції текстового поля 2 на формі.
            this.textBox2.ReadOnly = true; // Встановлення текстового поля 2 у режим лише для читання.
            this.textBox2.Size = new System.Drawing.Size(360, 29); // Встановлення розміру текстового поля 2.
            this.textBox2.Text = "Другий рядок"; // Встановлення тексту текстового поля 2.
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right; // Вирівнювання тексту текстового поля 2.

            // textBox3
            this.textBox3.BackColor = System.Drawing.Color.Yellow; // Встановлення фону текстового поля 3.
            this.textBox3.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline); // Налаштування шрифту текстового поля 3.
            this.textBox3.ForeColor = System.Drawing.Color.LightBlue; // Встановлення кольору тексту текстового поля 3.
            this.textBox3.Location = new System.Drawing.Point(12, 89); // Встановлення позиції текстового поля 3 на формі.
            this.textBox3.ReadOnly = true; // Встановлення текстового поля 3 у режим лише для читання.
            this.textBox3.Size = new System.Drawing.Size(360, 34); // Встановлення розміру текстового поля 3.
            this.textBox3.Text = "Третій рядок"; // Встановлення тексту текстового поля 3.
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; // Вирівнювання тексту текстового поля 3.

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлення параметрів автоматичного масштабування форми.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Встановлення режиму автоматичного масштабування.
            this.ClientSize = new System.Drawing.Size(384, 161); // Встановлення розміру клієнтської області форми.
            this.Controls.Add(this.textBox3); // Додавання текстового поля 3 на форму.
            this.Controls.Add(this.textBox2); // Додавання текстового поля 2 на форму.
            this.Controls.Add(this.textBox1); // Додавання текстового поля 1 на форму.
            this.Name = "Form1"; // Встановлення назви форми.
            this.Text = "Task_3"; // Встановлення заголовка форми.
            this.ResumeLayout(false); // Відновлення оновлення елементів форми.
            this.PerformLayout(); // Виконання розмітки форми.
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1; // Оголошення текстового поля 1.
        private System.Windows.Forms.TextBox textBox2; // Оголошення текстового поля 2.
        private System.Windows.Forms.TextBox textBox3; // Оголошення текстового поля 3.
    }
}
