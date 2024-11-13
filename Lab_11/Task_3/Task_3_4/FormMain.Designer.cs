namespace Task_3_4
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
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.buttonInputData);
            this.Name = "FormMain";
            this.Text = "Task 3.4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInputData;
    }
}
