namespace Lab_11_Task_2
{
    partial class FormH
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormM;
        private System.Windows.Forms.Button buttonOpenFormN;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonOpenFormM = new System.Windows.Forms.Button();
            this.buttonOpenFormN = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // buttonOpenFormM
            // 
            this.buttonOpenFormM.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFormM.Name = "buttonOpenFormM";
            this.buttonOpenFormM.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormM.Text = "Open Form M";
            this.buttonOpenFormM.Click += new System.EventHandler(this.buttonOpenFormM_Click);

            // 
            // buttonOpenFormN
            // 
            this.buttonOpenFormN.Location = new System.Drawing.Point(20, 80);
            this.buttonOpenFormN.Name = "buttonOpenFormN";
            this.buttonOpenFormN.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormN.Text = "Open Form N";
            this.buttonOpenFormN.Click += new System.EventHandler(this.buttonOpenFormN_Click);

            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(20, 140);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(200, 20);
            this.labelInfo.Text = "Label";

            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(20, 170);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(150, 20);

            // 
            // FormH
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.buttonOpenFormM);
            this.Controls.Add(this.buttonOpenFormN);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Text = "Form H";
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
