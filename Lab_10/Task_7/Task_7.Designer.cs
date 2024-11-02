namespace Lab_10
{
    partial class Task_7
    {
        private System.ComponentModel.IContainer components = null; // Контейнери
        private System.Windows.Forms.TextBox textBox1; // Текстове поле
        private System.Windows.Forms.StatusStrip statusStrip1; // Статус-стріп
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1; // Статус-лейбл 1
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2; // Статус-лейбл 2

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); 
            }
            base.Dispose(disposing); 
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox(); // Ініціалізація текстового поля
            this.statusStrip1 = new System.Windows.Forms.StatusStrip(); // Ініціалізація статус-стріпа
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel(); // Лейбл 1
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel(); // Лейбл 2
            this.statusStrip1.SuspendLayout(); // Зупинка для налаштувань
            this.SuspendLayout(); // Зупинка для форми

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(12, 12); 
            this.textBox1.Name = "textBox1"; 
            this.textBox1.Size = new System.Drawing.Size(200, 20); 
            this.textBox1.TabIndex = 0; // Індекс
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged); // Обробник

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { // Додавання лейблів
                this.toolStripStatusLabel1,
                this.toolStripStatusLabel2
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 240); 
            this.statusStrip1.Name = "statusStrip1"; // Ім'я
            this.statusStrip1.Size = new System.Drawing.Size(284, 22); 
            this.statusStrip1.TabIndex = 1; 
            this.statusStrip1.Text = "statusStrip1"; 

            // toolStripStatusLabel1
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1"; 
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17); 
            this.toolStripStatusLabel1.Text = "Поточна дата і час"; 

            // toolStripStatusLabel2
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2"; 
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 17); 
            this.toolStripStatusLabel2.Spring = true; // Розширення
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // Вирівнювання
            this.toolStripStatusLabel2.Text = "Літери у зворотному регістрі"; // Текст

            // Form7
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; 
            this.ClientSize = new System.Drawing.Size(284, 262); 
            this.Controls.Add(this.textBox1); 
            this.Controls.Add(this.statusStrip1); 
            this.Name = "Form7"; 
            this.Text = "Task 7"; 
            this.statusStrip1.ResumeLayout(false); 
            this.statusStrip1.PerformLayout(); 
            this.ResumeLayout(false); 
            this.PerformLayout(); 
        }
    }
}
