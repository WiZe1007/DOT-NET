namespace Task_3_2
{
    partial class FormMain
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
            this.buttonInputData = new System.Windows.Forms.Button();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInputData
            // 
            this.buttonInputData.Location = new System.Drawing.Point(20, 20);
            this.buttonInputData.Name = "buttonInputData";
            this.buttonInputData.Size = new System.Drawing.Size(100, 30);
            this.buttonInputData.TabIndex = 0;
            this.buttonInputData.Text = "Ввести дані";
            this.buttonInputData.UseVisualStyleBackColor = true;
            this.buttonInputData.Click += new System.EventHandler(this.buttonInputData_Click);
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(20, 70);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(65, 13);
            this.labelPerimeter.TabIndex = 1;
            this.labelPerimeter.Text = "Периметр:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(20, 100);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(45, 13);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Площа:";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.buttonInputData);
            this.Name = "FormMain";
            this.Text = "Task 3.2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonInputData;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelArea;
    }
}
