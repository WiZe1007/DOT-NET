namespace Task_10
{
    partial class Form1
    {
        // Змінні для компонентів форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1; // 1 текстовий блок
        private System.Windows.Forms.TextBox textBox2; // 2 текстовий блок
        private System.Windows.Forms.TextBox textBox3; // 3 текстовий блок

        // Метод для вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Вивільняємо компоненти
            }
            base.Dispose(disposing);
        }

        // Ініціалізація компонентів форми
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout(); // Починаємо компоновку

            // Налаштування для textBox1
            this.textBox1.Location = new System.Drawing.Point(100, 50); // Позиція
            this.textBox1.Name = "textBox1"; // Ім'я
            this.textBox1.Size = new System.Drawing.Size(200, 20); // Розмір
            this.textBox1.TabIndex = 0; // Індекс табуляції

            // Налаштування для textBox2
            this.textBox2.Location = new System.Drawing.Point(100, 100); // Позиція
            this.textBox2.Name = "textBox2"; // Ім'я
            this.textBox2.Size = new System.Drawing.Size(200, 20); // Розмір
            this.textBox2.TabIndex = 1; // Індекс табуляції

            // Налаштування для textBox3
            this.textBox3.Location = new System.Drawing.Point(100, 150); // Позиція
            this.textBox3.Name = "textBox3"; // Ім'я
            this.textBox3.Size = new System.Drawing.Size(200, 20); // Розмір
            this.textBox3.TabIndex = 2; // Індекс табуляції

            // Налаштування основних параметрів форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Масштабування
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабування
            this.ClientSize = new System.Drawing.Size(400, 250); 
            this.Controls.Add(this.textBox1); 
            this.Controls.Add(this.textBox2); 
            this.Controls.Add(this.textBox3); 
            this.Name = "Form1"; 
            this.Text = "Task 10"; 
            this.ResumeLayout(false); // Завершуємо компоновку
            this.PerformLayout(); // Виконуємо розміщення компонентів
        }
    }
}
