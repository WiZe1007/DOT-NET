namespace Lab_11_Task_2
{
    partial class FormG
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFormH;
        private System.Windows.Forms.Button buttonOpenFormI;
        private System.Windows.Forms.Button buttonOpenFormJ;
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
            this.buttonOpenFormH = new System.Windows.Forms.Button();
            this.buttonOpenFormI = new System.Windows.Forms.Button();
            this.buttonOpenFormJ = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // buttonOpenFormH
            // 
            this.buttonOpenFormH.Location = new System.Drawing.Point(20, 20);
            this.buttonOpenFormH.Name = "buttonOpenFormH";
            this.buttonOpenFormH.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormH.Text = "Open Form H";
            this.buttonOpenFormH.Click += new System.EventHandler(this.buttonOpenFormH_Click);

            // 
            // buttonOpenFormI
            // 
            this.buttonOpenFormI.Location = new System.Drawing.Point(20, 80);
            this.buttonOpenFormI.Name = "buttonOpenFormI";
            this.buttonOpenFormI.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormI.Text = "Open Form I";
            this.buttonOpenFormI.Click += new System.EventHandler(this.buttonOpenFormI_Click);

            // 
            // buttonOpenFormJ
            // 
            this.buttonOpenFormJ.Location = new System.Drawing.Point(20, 140);
            this.buttonOpenFormJ.Name = "buttonOpenFormJ";
            this.buttonOpenFormJ.Size = new System.Drawing.Size(150, 50);
            this.buttonOpenFormJ.Text = "Open Form J";
            this.buttonOpenFormJ.Click += new System.EventHandler(this.buttonOpenFormJ_Click);

            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(20, 200);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(200, 20);
            this.labelInfo.Text = "Label";

            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(20, 230);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(150, 20);

            // 
            // FormG
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.buttonOpenFormH);
            this.Controls.Add(this.buttonOpenFormI);
            this.Controls.Add(this.buttonOpenFormJ);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Text = "Form G";
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
