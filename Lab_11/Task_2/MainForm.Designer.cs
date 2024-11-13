namespace Lab_11_Task_2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormG;
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
            this.buttonOpenFormG = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // buttonOpenFormG
            // 
            this.buttonOpenFormG.Location = new System.Drawing.Point(50, 20);
            this.buttonOpenFormG.Name = "buttonOpenFormG";
            this.buttonOpenFormG.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormG.Text = "Open Form G";
            this.buttonOpenFormG.Click += new System.EventHandler(this.buttonOpenFormG_Click);

            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(50, 80);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(150, 20);
            this.labelInfo.Text = "Welcome!";

            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(50, 110);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(150, 20);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.buttonOpenFormG);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
