namespace Lab_11
{
    partial class FormH
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormM;
        private System.Windows.Forms.Button buttonOpenFormN;

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
            this.SuspendLayout();

            // buttonOpenFormM
            this.buttonOpenFormM.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFormM.Name = "buttonOpenFormM";
            this.buttonOpenFormM.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormM.Text = "Open Form M";
            this.buttonOpenFormM.Click += new System.EventHandler(this.buttonOpenFormM_Click);

            // buttonOpenFormN
            this.buttonOpenFormN.Location = new System.Drawing.Point(20, 80);
            this.buttonOpenFormN.Name = "buttonOpenFormN";
            this.buttonOpenFormN.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormN.Text = "Open Form N";
            this.buttonOpenFormN.Click += new System.EventHandler(this.buttonOpenFormN_Click);

            // FormH
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.buttonOpenFormM);
            this.Controls.Add(this.buttonOpenFormN);
            this.Text = "Form H";
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ResumeLayout(false);
        }
    }
}
