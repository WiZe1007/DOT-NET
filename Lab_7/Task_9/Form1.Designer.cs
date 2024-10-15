namespace Task_09
{
    partial class Form1
    {
        // Контейнери для компонентів форми
        private System.ComponentModel.IContainer components = null;
        // Текстові поля для введення даних
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

        // Метод для звільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            // Якщо компоненти існують, звільняємо їх
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); // Викликаємо базовий метод
        }

        // Метод ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Створюємо нові текстові поля
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout(); // Припиняємо оновлення

            // Налаштування textBox1
            this.textBox1.Location = new System.Drawing.Point(100, 50); // Позиція на формі
            this.textBox1.Name = "textBox1"; // Ім'я поля
            this.textBox1.Size = new System.Drawing.Size(200, 20); // Розміри поля
            this.textBox1.TabIndex = 0; // Порядок табуляції

            // Налаштування textBox2
            this.textBox2.Location = new System.Drawing.Point(100, 100); // Позиція
            this.textBox2.Name = "textBox2"; // Ім'я поля
            this.textBox2.Size = new System.Drawing.Size(200, 20); // Розміри
            this.textBox2.TabIndex = 1; // Порядок табуляції

            // Налаштування textBox3
            this.textBox3.Location = new System.Drawing.Point(100, 150); // Позиція
            this.textBox3.Name = "textBox3"; // Ім'я поля
            this.textBox3.Size = new System.Drawing.Size(200, 20); // Розміри
            this.textBox3.TabIndex = 2; // Порядок табуляції

            // Налаштування загальних параметрів форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабування
            this.ClientSize = new System.Drawing.Size(400, 250); // Розміри вікна
            this.Controls.Add(this.textBox1); 
            this.Controls.Add(this.textBox2); 
            this.Controls.Add(this.textBox3); 
            this.Name = "Form1"; 
            this.Text = "Task 9"; 
            this.ResumeLayout(false); // Продовжуємо оновлення
            this.PerformLayout(); // Завершуємо налаштування
        }
    }
}
