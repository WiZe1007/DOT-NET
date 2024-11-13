namespace Task_4_2
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

        #region Код, згенерований конструктором форм Windows

        private void InitializeComponent()
        {
            this.btnOpenInputForm = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenInputForm
            // 
            this.btnOpenInputForm.Location = new System.Drawing.Point(30, 30);
            this.btnOpenInputForm.Name = "btnOpenInputForm";
            this.btnOpenInputForm.Size = new System.Drawing.Size(150, 30);
            this.btnOpenInputForm.TabIndex = 0;
            this.btnOpenInputForm.Text = "Ввести дані";
            this.btnOpenInputForm.UseVisualStyleBackColor = true;
            this.btnOpenInputForm.Click += new System.EventHandler(this.btnOpenInputForm_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(74, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOpenInputForm);
            this.Name = "Form1";
            this.Text = "Task 4.2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOpenInputForm;
        private System.Windows.Forms.Label lblResult;
    }
}
