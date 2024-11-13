namespace Task_3_4
{
    partial class FormResult
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований Конструктором Windows Form Designer

        private void InitializeComponent()
        {
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(20, 20);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(65, 13);
            this.labelPerimeter.TabIndex = 0;
            this.labelPerimeter.Text = "Периметр:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(20, 50);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(45, 13);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Площа:";
            // 
            // FormResult
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelPerimeter);
            this.Name = "FormResult";
            this.Text = "Результати";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelArea;
    }
}
