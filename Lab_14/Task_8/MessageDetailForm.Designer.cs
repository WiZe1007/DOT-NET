namespace Lab__12
{
    partial class MessageDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label dateLabel;

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
            this.detailLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // detailLabel
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.detailLabel.Location = new System.Drawing.Point(100, 20);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(196, 37);
            this.detailLabel.Text = "Message Detail";

            // fromLabel
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fromLabel.Location = new System.Drawing.Point(20, 70);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(47, 21);
            this.fromLabel.Text = "From:";

            // themeLabel
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.themeLabel.Location = new System.Drawing.Point(20, 100);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(59, 21);
            this.themeLabel.Text = "Theme:";

            // textTextBox
            this.textTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textTextBox.Location = new System.Drawing.Point(20, 130);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.ReadOnly = true;
            this.textTextBox.Size = new System.Drawing.Size(360, 200);
            this.textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // dateLabel
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateLabel.Location = new System.Drawing.Point(20, 340);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 21);
            this.dateLabel.Text = "Date:";

            // MessageDetailForm
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.dateLabel);
            this.Name = "MessageDetailForm";
            this.Text = "Message Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
