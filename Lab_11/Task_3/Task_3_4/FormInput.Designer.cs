namespace Task_3_4
{
    partial class FormInput
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
            this.labelHypotenuse = new System.Windows.Forms.Label();
            this.textBoxHypotenuse = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
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
            this.textBoxHypotenuse.Location = new System.Drawing.Point(100, 17);
            this.textBoxHypotenuse.Name = "textBoxHypotenuse";
            this.textBoxHypotenuse.Size = new System.Drawing.Size(100, 20);
            this.textBoxHypotenuse.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(100, 60);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Ок";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormInput
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxHypotenuse);
            this.Controls.Add(this.labelHypotenuse);
            this.Name = "FormInput";
            this.Text = "Введення Даних";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHypotenuse;
        private System.Windows.Forms.TextBox textBoxHypotenuse;
        private System.Windows.Forms.Button buttonOK;
    }
}
