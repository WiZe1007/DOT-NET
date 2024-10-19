namespace Task_07
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null; // Контейнери компонентів
        private Label label1; // 1 мітка
        private Label label2; // 2 мітка
        private Label label3; // 3 мітка
        private ContextMenuStrip contextMenu; // Контекстне меню

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Вивільнення ресурсів
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // Ініціалізація контейнера
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components); // Ініціалізація контекстного меню
            this.label1 = new System.Windows.Forms.Label(); // Ініціалізація мітки 1
            this.label2 = new System.Windows.Forms.Label(); // Ініціалізація мітки 2
            this.label3 = new System.Windows.Forms.Label(); // Ініціалізація мітки 3
            this.SuspendLayout(); // Початок зміни форми

            // Налаштування label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label 1";

            // Налаштування label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label 2";

            // Налаштування label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Label 3";

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Task 7";
            this.ResumeLayout(false); // Завершення зміни форми
            this.PerformLayout(); // Застосування налаштувань
        }
    }
}
