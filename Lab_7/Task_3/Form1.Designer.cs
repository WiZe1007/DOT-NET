namespace Task_003
{
    partial class Form1
    {
        // Контейнер для компонентів форми
        private System.ComponentModel.IContainer components = null;

        // Метод для вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільняємо ресурси, якщо вони існують
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Метод ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Створення трьох міток (Label)
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout(); // Підготовка до додавання компонентів

            // 
            // label1
            // 
            this.label1.AutoSize = true; // Автоматичне розміщення мітки
            this.label1.Location = new System.Drawing.Point(100, 50); // Позиція мітки на формі
            this.label1.Name = "label1"; // Ім'я 
            this.label1.Size = new System.Drawing.Size(46, 17); // Розміри 
            this.label1.TabIndex = 0; // Порядок табуляції
            this.label1.Text = "Label 1"; // Текст 

            // 
            // label2
            // 
            this.label2.AutoSize = true; // Автоматичне розміщення мітки
            this.label2.Location = new System.Drawing.Point(100, 100); // Позиція мітки на формі
            this.label2.Name = "label2"; // Ім'я 
            this.label2.Size = new System.Drawing.Size(46, 17); // Розміри 
            this.label2.TabIndex = 1; // Порядок табуляції
            this.label2.Text = "Label 2"; // Текст 

            // 
            // label3
            // 
            this.label3.AutoSize = true; // Автоматичне розміщення мітки
            this.label3.Location = new System.Drawing.Point(100, 150); // Позиція мітки на формі
            this.label3.Name = "label3"; // Ім'я
            this.label3.Size = new System.Drawing.Size(46, 17); // Розміри
            this.label3.TabIndex = 2; // Порядок табуляції
            this.label3.Text = "Label 3"; // Текст

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштабування форми
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабування
            this.ClientSize = new System.Drawing.Size(282, 253); // Розміри вікна
            // Додавання міток до форми
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1"; // Ім'я 
            this.Text = "Task 3"; // Заголовок 
            this.ResumeLayout(false); // Завершення роботи з розкладкою
            this.PerformLayout(); // Виконання всіх необхідних дій з компонентами
        }

        #endregion

        // Оголошення міток для використання в формі
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
