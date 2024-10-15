namespace Task_07
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Очищення ресурсів при закритті форми
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Вивільнення компонентів
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Ініціалізація компонентів форми
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label(); // 1 лейбл
            this.label2 = new System.Windows.Forms.Label(); // 2 лейбл
            this.label3 = new System.Windows.Forms.Label(); // 3 лейбл
            this.SuspendLayout(); // Початок налаштувань

            // 
            // label1
            // 
            this.label1.AutoSize = true; // Авто розмір
            this.label1.Location = new System.Drawing.Point(100, 100); // Позиція
            this.label1.Name = "label1"; // Ім'я
            this.label1.Size = new System.Drawing.Size(46, 17); // Розмір
            this.label1.TabIndex = 0; // Порядок
            this.label1.Text = "Текст 1"; // Текст
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown1); // Обробник натискання
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp1); // Обробник відпускання

            // 
            // label2
            // 
            this.label2.AutoSize = true; // Авто розмір
            this.label2.Location = new System.Drawing.Point(100, 150); // Позиція
            this.label2.Name = "label2"; // Ім'я
            this.label2.Size = new System.Drawing.Size(46, 17); // Розмір
            this.label2.TabIndex = 1; // Порядок
            this.label2.Text = "Текст 2"; // Текст
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown2); // Обробник натискання
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp2); // Обробник відпускання

            // 
            // label3
            // 
            this.label3.AutoSize = true; // Авто розмір
            this.label3.Location = new System.Drawing.Point(100, 200); // Позиція
            this.label3.Name = "label3"; // Ім'я
            this.label3.Size = new System.Drawing.Size(46, 17); // Розмір
            this.label3.TabIndex = 2; // Порядок
            this.label3.Text = "Текст 3"; // Текст
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown3); // Обробник натискання
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseUp3); // Обробник відпускання

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабу
            this.ClientSize = new System.Drawing.Size(282, 253); // Розмір форми
            this.Controls.Add(this.label3); // Додаємо 3 лейбл
            this.Controls.Add(this.label2); // Додаємо 2 лейбл
            this.Controls.Add(this.label1); // Додаємо 1 лейбл
            this.Name = "Form1"; // Назва форми
            this.Text = "Task 7"; // Заголовок
            this.ResumeLayout(false); // Завершення налаштувань
            this.PerformLayout(); // Розміщення
        }

        #endregion

        // Оголошення лейблів
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
