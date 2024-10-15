namespace Task_13
{
    partial class Form1
    {
        // Контейнери для компонентів
        private System.ComponentModel.IContainer components = null;

        // Очищення ресурсів
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
            this.SuspendLayout(); // Початок налаштувань

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Task 13"; // Заголовок

            this.ResumeLayout(false); // Завершення налаштувань
        }

        #endregion
    }
}
