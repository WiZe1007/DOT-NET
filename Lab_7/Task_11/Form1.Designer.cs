namespace Task_11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null; // Контейнери для компонентів
        private System.Windows.Forms.TextBox textBox1; // Текстове поле

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 100); // Позиція текстового поля
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22); // Розмір текстового поля
            this.textBox1.TabIndex = 0; // Перший елемент фокусу
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress); // Обробник натискань клавіш
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown); // Обробник натискань клавіш
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp); // Обробник відпускання клавіш
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Масштабування
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250); // Розмір форми
            this.Controls.Add(this.textBox1); // Додавання текстового поля
            this.Name = "Form1";
            this.Text = "Task 11"; // Заголовок форми
            this.Resize += new System.EventHandler(this.Form1_Resize); // Обробка зміни розміру
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
