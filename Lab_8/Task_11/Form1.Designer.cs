namespace Task_11
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            // Ініціалізація кнопки
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Налаштування властивостей кнопки
            this.button1.Location = new System.Drawing.Point(100, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = true;

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Task 11";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
    }
}
