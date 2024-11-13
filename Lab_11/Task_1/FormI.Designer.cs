namespace Lab_11
{
    partial class FormI
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

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // FormI
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Text = "Form I";
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ResumeLayout(false);
        }
    }
}
