namespace Task_4_4
{
    partial class InputForm
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

        #region Код, згенерований конструктором форм Windows

        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblX
            //
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(30, 30);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "x:";
            //
            // txtX
            //
            this.txtX.Location = new System.Drawing.Point(60, 27);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 1;
            //
            // lblY
            //
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(30, 70);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 17);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "y:";
            //
            // txtY
            //
            this.txtY.Location = new System.Drawing.Point(60, 67);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 3;
            //
            // lblZ
            //
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(30, 110);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 17);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "z:";
            //
            // txtZ
            //
            this.txtZ.Location = new System.Drawing.Point(60, 107);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 22);
            this.txtZ.TabIndex = 5;
            //
            // btnOK
            //
            this.btnOK.Location = new System.Drawing.Point(60, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Підтвердити";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // InputForm
            //
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "InputForm";
            this.Text = "Введення даних";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnOK;
    }
}
