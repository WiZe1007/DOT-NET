namespace Task_4_4
{
    partial class ResultsForm
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblResult
            //
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(30, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Результат:";
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(80, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // ResultsForm
            //
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblResult);
            this.Name = "ResultsForm";
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClose;
    }
}
