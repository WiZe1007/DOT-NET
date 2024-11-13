namespace Lab_11_Task_4
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
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
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(60, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            //
            // lblResult
            //
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 200);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(74, 17);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Результат:";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 251);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Task 4.1";
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
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
