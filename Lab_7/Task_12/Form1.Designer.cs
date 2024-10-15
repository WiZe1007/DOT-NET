namespace Task_12
{
    partial class Form1
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBox1; // Комбо-бокс
        private System.Windows.Forms.ListBox listBox1;   // Список

        // Вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Вивільняємо компоненти
            }
            base.Dispose(disposing);
        }

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout(); // Початок налаштування

            // Налаштування comboBox1
            this.comboBox1.FormattingEnabled = true; // Дозволити форматування
            this.comboBox1.Location = new System.Drawing.Point(50, 30); // Позиція
            this.comboBox1.Name = "comboBox1"; // Назва
            this.comboBox1.Size = new System.Drawing.Size(200, 24); // Розмір
            this.comboBox1.TabIndex = 0; // Індекс
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged); // Обробник

            // Налаштування listBox1
            this.listBox1.FormattingEnabled = true; // Дозволити форматування
            this.listBox1.ItemHeight = 16; // Висота
            this.listBox1.Location = new System.Drawing.Point(50, 80); // Позиція
            this.listBox1.Name = "listBox1"; // Назва
            this.listBox1.Size = new System.Drawing.Size(200, 100); // Розмір
            this.listBox1.TabIndex = 1; // Індекс
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick); // Обробник

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабу
            this.ClientSize = new System.Drawing.Size(300, 250); 
            this.Controls.Add(this.listBox1); // Додати список
            this.Controls.Add(this.comboBox1); // Додати комбо-бокс
            this.Name = "Form1"; 
            this.Text = "Task 12"; 
            this.ResumeLayout(false); // Завершити налаштування
        }
    }
}
