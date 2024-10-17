namespace Task_08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Метод для очищення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Ініціалізація компонентів для форми
        private void InitializeComponent()
        {
            // Створення трьох міток
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout(); // Початок налаштування

            // Налаштування властивостей label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст 1";
            // Додавання обробників подій для label1
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseHandler);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseHandler);

            // Налаштування властивостей label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текст 2";
            // Додавання обробників подій для label2
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseHandler);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseHandler);

            // Налаштування властивостей label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Текст 3";
            // Додавання обробників подій для label3
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseHandler);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_MouseHandler);

            // Налаштування основних властивостей форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label3); // Додавання label3 на форму
            this.Controls.Add(this.label2); // Додавання label2 на форму
            this.Controls.Add(this.label1); // Додавання label1 на форму
            this.Name = "Form1"; // Назва форми
            this.Text = "Task 8"; // Заголовок форми
            this.ResumeLayout(false); // Завершення налаштувань
            this.PerformLayout(); // Примусове оновлення інтерфейсу
        }

        #endregion

        // Оголошення трьох міток
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
