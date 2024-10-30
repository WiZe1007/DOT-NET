namespace Lab_9
{
    partial class Task_3
    {
        private System.ComponentModel.IContainer components = null; // Контейнери компонентів
        private System.Windows.Forms.Label label1; // Мітка для введення
        private System.Windows.Forms.TextBox textBox1; // Поле для вводу
        private System.Windows.Forms.Button button1; // Кнопка для підтвердження
        private System.Windows.Forms.Label resultLabel; // Мітка для результату

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout(); // Початок налаштування

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кілометри"; // Текст мітки

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(100, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += (s, e) => TextBox1_TextChanged(); // Обробка зміни тексту

            // button1
            this.button1.Enabled = false; // Спочатку вимкнена
            this.button1.Location = new System.Drawing.Point(40, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK"; // Текст на кнопці
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += (s, e) => Button1_Click(); // Обробка кліку

            // resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(25, 100);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 3; // Мітка результату

            // Form3
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161); 
            this.Controls.Add(this.resultLabel); // Додавання мітки результату
            this.Controls.Add(this.button1); // Додавання кнопки
            this.Controls.Add(this.textBox1); // Додавання поля вводу
            this.Controls.Add(this.label1); // Додавання мітки
            this.Name = "Form3";
            this.Text = "Task 3"; 
            this.ResumeLayout(false);
            this.PerformLayout(); 
        }
    }
}
