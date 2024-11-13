namespace Lab_11_Task_3
{
    partial class MainForm
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

        #region Код, створений конструктором форм Windows

        private void InitializeComponent()
        {
            this.labelHypotenuse = new System.Windows.Forms.Label();
            this.textBoxHypotenuse = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHypotenuse
            // 
            this.labelHypotenuse.AutoSize = true;
            this.labelHypotenuse.Location = new System.Drawing.Point(20, 20);
            this.labelHypotenuse.Name = "labelHypotenuse";
            this.labelHypotenuse.Size = new System.Drawing.Size(71, 13);
            this.labelHypotenuse.TabIndex = 0;
            this.labelHypotenuse.Text = "Гіпотенуза:";
            // 
            // textBoxHypotenuse
            // 
            this.textBoxHypotenuse.Location = new System.Drawing.Point(120, 17);
            this.textBoxHypotenuse.Name = "textBoxHypotenuse";
            this.textBoxHypotenuse.Size = new System.Drawing.Size(150, 20);
            this.textBoxHypotenuse.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(120, 60);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 30);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(20, 110);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(57, 13);
            this.labelPerimeter.TabIndex = 3;
            this.labelPerimeter.Text = "Периметр:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(20, 140);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(43, 13);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "Площа:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxHypotenuse);
            this.Controls.Add(this.labelHypotenuse);
            this.Name = "Form1";
            this.Text = "Task 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHypotenuse;
        private System.Windows.Forms.TextBox textBoxHypotenuse;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelArea;
    }
}
