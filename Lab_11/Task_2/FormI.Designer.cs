namespace Lab_11_Task_2
{
    partial class FormI
    {
        private System.ComponentModel.IContainer components = null;
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(20, 80);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(200, 20);
            this.labelInfo.Text = "Label";

            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(20, 110);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(150, 20);

            // 
            // FormI
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Text = "Form I";
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
