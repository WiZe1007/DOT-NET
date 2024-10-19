namespace Task_10 
{
    partial class Form1 
    {
        private System.ComponentModel.IContainer components = null; // Компоненти
        private System.Windows.Forms.ToolStrip toolStrip1; // Панель інструментів
        private System.Windows.Forms.ToolStripButton toolStripButton1; // Кнопка 1
        private System.Windows.Forms.ToolStripButton toolStripButton2; // Кнопка 2
        private System.Windows.Forms.ToolStripButton toolStripButton3; // Кнопка 3
        private System.Windows.Forms.ToolStripButton toolStripButton4; // Кнопка 4

        protected override void Dispose(bool disposing) 
        {
            if (disposing && (components != null))
            {
                components.Dispose(); 
            }
            base.Dispose(disposing); 
        }

        private void InitializeComponent() // Ініціалізація
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip(); // Панель інструментів
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton(); // Кнопка 1
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton(); // Кнопка 2
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton(); // Кнопка 3
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton(); // Кнопка 4

            this.toolStrip1.SuspendLayout(); // Призупинення
            this.SuspendLayout(); // Призупинення форми

            // Налаштування панелі інструментів
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripButton1,
                this.toolStripButton2,
                this.toolStripButton3,
                this.toolStripButton4
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // Налаштування кнопок
            SetButtonProperties(toolStripButton1, @"res\Icon1.png", "Tool1");
            SetButtonProperties(toolStripButton2, @"res\Icon2.png", "Tool2");
            SetButtonProperties(toolStripButton3, @"res\Icon3.png", "Tool3");
            SetButtonProperties(toolStripButton4, @"res\Icon4.png", "Tool4");

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Task 10";

            this.toolStrip1.ResumeLayout(false); // Відновлення
            this.toolStrip1.PerformLayout(); 
            this.ResumeLayout(false); 
            this.PerformLayout(); 
        }

        private void SetButtonProperties(ToolStripButton button, string imagePath, string text) // Налаштування кнопок
        {
            button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            button.Image = System.Drawing.Image.FromFile(imagePath);
            button.ImageTransparentColor = System.Drawing.Color.Magenta;
            button.Size = new System.Drawing.Size(23, 22);
            button.Text = text;
        }
    }
}
