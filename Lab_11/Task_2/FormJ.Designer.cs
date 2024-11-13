namespace Lab_11_Task_2
{
    partial class FormJ
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormK;
        private System.Windows.Forms.Button buttonOpenFormL;
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
            this.buttonOpenFormK = new System.Windows.Forms.Button();
            this.buttonOpenFormL = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // buttonOpenFormK
            // 
            this.buttonOpenFormK.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFormK.Name = "buttonOpenFormK";
            this.buttonOpenFormK.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormK.Text = "Open Form K";
            this.buttonOpenFormK.Click += new System.EventHandler(this.buttonOpenFormK_Click);

            // 
            // buttonOpenFormL
            // 
            this.buttonOpenFormL.Location = new System.Drawing.Point(20, 80);
            this.buttonOpenFormL.Name = "buttonOpenFormL";
            this.buttonOpenFormL.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormL.Text = "Open Form L";
            this.buttonOpenFormL.Click += new System.EventHandler(this.buttonOpenFormL_Click);

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
            // FormJ
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.buttonOpenFormK);
            this.Controls.Add(this.buttonOpenFormL);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Text = "Form J";
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
