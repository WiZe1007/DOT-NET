namespace Lab_11_Task_8
{
    partial class AboutForm
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

        #region Код, необхідний для конструктора форм Windows

        private void InitializeComponent()
        {
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(12, 9);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(180, 13);
            this.labelDeveloper.TabIndex = 0;
            this.labelDeveloper.Text = "Ця програма розроблена Мельник Богданом, КН-922в, 3 курс";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(180, 35);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 50);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AboutForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDeveloper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AboutForm";
            this.Text = "Про програму";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Button buttonClose;
    }
}
