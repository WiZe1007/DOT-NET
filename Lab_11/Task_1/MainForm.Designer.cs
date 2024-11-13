namespace Lab_11
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormG;

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
            this.buttonOpenFormG = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // buttonOpenFormG
            this.buttonOpenFormG.Location = new System.Drawing.Point(50, 50);
            this.buttonOpenFormG.Name = "buttonOpenFormG";
            this.buttonOpenFormG.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormG.Text = "Open Form G";
            this.buttonOpenFormG.Click += new System.EventHandler(this.buttonOpenFormG_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.buttonOpenFormG);
            this.Text = "Main Form";
            this.ResumeLayout(false);
        }
    }
}
