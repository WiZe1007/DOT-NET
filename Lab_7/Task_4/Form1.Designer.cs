namespace Task_04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Очищення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення компонентів
            }
            base.Dispose(disposing);
        }

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            // Створення міток
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout(); // Початок налаштувань

            // Налаштування label1
            this.label1.AutoSize = true; // Автоматичний розмір
            this.label1.Location = new System.Drawing.Point(100, 50); // Позиція
            this.label1.Name = "label1"; // Ім'я
            this.label1.Size = new System.Drawing.Size(46, 17); // Розмір
            this.label1.TabIndex = 0; // Індекс
            this.label1.Text = "Label 1"; // Текст
            this.label1.DoubleClick += new System.EventHandler(this.Label_DoubleClick); // Подія

            // Налаштування label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 100); // Позиція
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17); // Розмір
            this.label2.TabIndex = 1;
            this.label2.Text = "Label 2";
            this.label2.DoubleClick += new System.EventHandler(this.Label_DoubleClick);

            // Налаштування label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 150); // Позиція
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17); // Розмір
            this.label3.TabIndex = 2;
            this.label3.Text = "Label 3";
            this.label3.DoubleClick += new System.EventHandler(this.Label_DoubleClick);

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим
            this.ClientSize = new System.Drawing.Size(282, 253); // Розміри
            this.Controls.Add(this.label3); // Додавання міток
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1"; // Ім'я форми
            this.Text = "Task 4"; // Заголовок
            this.ResumeLayout(false); // Завершення налаштувань
            this.PerformLayout(); // Перерахунок
        }

        // Оголошення міток
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
