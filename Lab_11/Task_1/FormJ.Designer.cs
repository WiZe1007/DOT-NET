namespace Lab_11
{
    partial class FormJ
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormK;
        private System.Windows.Forms.Button buttonOpenFormL;

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
            this.buttonOpenFormK = new System.Windows.Forms.Button();
            this.buttonOpenFormL = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // buttonOpenFormK
            this.buttonOpenFormK.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFormK.Name = "buttonOpenFormK";
            this.buttonOpenFormK.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormK.Text = "Open Form K";
            this.buttonOpenFormK.Click += new System.EventHandler(this.buttonOpenFormK_Click);

            // buttonOpenFormL
            this.buttonOpenFormL.Location = new System.Drawing.Point(20, 80);
            this.buttonOpenFormL.Name = "buttonOpenFormL";
            this.buttonOpenFormL.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormL.Text = "Open Form L";
            this.buttonOpenFormL.Click += new System.EventHandler(this.buttonOpenFormL_Click);

            // FormJ
            this.ClientSize = new System.Drawing.Size(200, 150);
            this.Controls.Add(this.buttonOpenFormK);
            this.Controls.Add(this.buttonOpenFormL);
            this.Text = "Form J";
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ResumeLayout(false);
        }
    }
}
