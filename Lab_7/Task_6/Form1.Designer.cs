namespace Task_06
{
    partial class Form1
    {
        // Змінна для зберігання компонентів форми
        private System.ComponentModel.IContainer components = null;

        // Метод для звільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів компонентів
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Метод ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Ініціалізація кнопок
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout(); // Початок змін

            // Кнопка 1
            this.button1.Location = new System.Drawing.Point(150, 100); // Встановлення позиції
            this.button1.Name = "button1"; // Ім'я кнопки
            this.button1.Size = new System.Drawing.Size(100, 50); // Розміри
            this.button1.TabIndex = 0; // Порядок табуляції
            this.button1.Text = "Button 1"; // Текст
            this.button1.UseVisualStyleBackColor = true; // Використання стилю
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseHover); // Подія наведення миші
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseHover); // Подія покидання кнопки

            // Кнопка 2
            this.button2.Location = new System.Drawing.Point(300, 100); // Встановлення позиції
            this.button2.Name = "button2"; // Ім'я
            this.button2.Size = new System.Drawing.Size(100, 50); // Розміри 
            this.button2.TabIndex = 1; // Порядок табуляції
            this.button2.Text = "Button 2"; // Текст 
            this.button2.UseVisualStyleBackColor = true; // Використання стилю
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseHover); // Подія наведення миші
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseHover); // Подія покидання кнопки

            // Кнопка 3
            this.button3.Location = new System.Drawing.Point(450, 100); // Встановлення позиції
            this.button3.Name = "button3"; // Ім'я кнопки
            this.button3.Size = new System.Drawing.Size(100, 50); // Розміри 
            this.button3.TabIndex = 2; // Порядок табуляції
            this.button3.Text = "Button 3"; // Текст
            this.button3.UseVisualStyleBackColor = true; // Використання стилю
            this.button3.MouseEnter += new System.EventHandler(this.button_MouseHover); // Подія наведення миші
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseHover); // Подія покидання кнопки

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабування
            this.ClientSize = new System.Drawing.Size(700, 300); // Розміри форми
            this.Controls.Add(this.button3); // Додавання кнопки 3
            this.Controls.Add(this.button2); // Додавання кнопки 2
            this.Controls.Add(this.button1); // Додавання кнопки 1
            this.Name = "Form1"; // Ім'я форми
            this.Text = "Task 6"; // Заголовок форми
            this.ResumeLayout(false); // Кінець змін
        }

        #endregion

        // Оголошення кнопок
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
