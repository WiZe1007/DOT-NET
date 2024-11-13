namespace Task_4_4
{
    partial class MainForm
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

        /// <summary>
        /// Метод, необхідний для підтримки конструктора — не змінюйте
        /// його вміст за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btnStart
            //
            this.btnStart.Location = new System.Drawing.Point(50, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Розпочати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Task 4.4";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
    }
}
