namespace Task_05
{
    partial class Form1
    {
        // Контейнер для компонентів
        private System.ComponentModel.IContainer components = null;

        // Вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            // Створення кнопок
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout(); // Початок налаштувань

            // Налаштування button1
            this.button1.Location = new System.Drawing.Point(150, 100); // Позиція
            this.button1.Name = "button1"; // Назва
            this.button1.Size = new System.Drawing.Size(100, 50); // Розмір
            this.button1.TabIndex = 0; // Індекс
            this.button1.Text = "Button 1"; // Текст
            this.button1.UseVisualStyleBackColor = true; // Стиль

            // Налаштування button2
            this.button2.Location = new System.Drawing.Point(300, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Button 2";
            this.button2.UseVisualStyleBackColor = true;

            // Налаштування button3
            this.button3.Location = new System.Drawing.Point(450, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Button 3";
            this.button3.UseVisualStyleBackColor = true;

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим
            this.ClientSize = new System.Drawing.Size(700, 300); // Розмір
            this.Controls.Add(this.button3); // Додавання кнопок
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1"; // Назва форми
            this.Text = "Task 5"; // Заголовок
            this.ResumeLayout(false); // Завершення налаштувань
        }

        #endregion

        // Оголошення кнопок
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
