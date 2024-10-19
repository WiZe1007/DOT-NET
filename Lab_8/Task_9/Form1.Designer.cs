namespace Task_09 
{
    partial class Form1 
    {
        private System.ComponentModel.IContainer components = null; 
        private System.Windows.Forms.ToolStrip toolStrip1; 
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

        private void InitializeComponent() // Ініціалізація компонентів
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip(); // Створення панелі
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton(); // Створення кнопки 1
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton(); // Створення кнопки 2
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton(); // Створення кнопки 3
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton(); // Створення кнопки 4
            this.toolStrip1.SuspendLayout(); 
            this.SuspendLayout(); 

            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1, 
            this.toolStripButton2, 
            this.toolStripButton3, 
            this.toolStripButton4}); 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1"; 
            this.toolStrip1.Size = new System.Drawing.Size(800, 25); 
            this.toolStrip1.TabIndex = 0; 
            this.toolStrip1.Text = "toolStrip1"; 

            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; 
            this.toolStripButton1.Image = System.Drawing.Image.FromFile(@"res\Icon1.png"); 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta; 
            this.toolStripButton1.Name = "toolStripButton1"; 
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22); 
            this.toolStripButton1.Text = "Tool1"; 

            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; 
            this.toolStripButton2.Image = System.Drawing.Image.FromFile(@"res\Icon2.png");
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta; 
            this.toolStripButton2.Name = "toolStripButton2"; 
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22); 
            this.toolStripButton2.Text = "Tool2"; 

            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; 
            this.toolStripButton3.Image = System.Drawing.Image.FromFile(@"res\Icon3.png"); 
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta; 
            this.toolStripButton3.Name = "toolStripButton3"; 
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22); 
            this.toolStripButton3.Text = "Tool3"; 

            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; 
            this.toolStripButton4.Image = System.Drawing.Image.FromFile(@"res\Icon4.png"); 
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta; 
            this.toolStripButton4.Name = "toolStripButton4"; 
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22); 
            this.toolStripButton4.Text = "Tool4"; 

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; 
            this.ClientSize = new System.Drawing.Size(800, 450); 
            this.Controls.Add(this.toolStrip1); 
            this.Name = "Form1"; 
            this.Text = "Task 9"; 

            this.toolStrip1.ResumeLayout(false); 
            this.toolStrip1.PerformLayout(); // Виконання розташування
            this.ResumeLayout(false); 
            this.PerformLayout(); // Виконання розташування
        }
    }
}
