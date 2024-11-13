namespace Lab_11_Task_6
{
    partial class ConfigForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonColorLabelTitle;
        private System.Windows.Forms.Button buttonFontLabelTitle;
        private System.Windows.Forms.Button buttonColorGroupBoxContactInfo;
        private System.Windows.Forms.Button buttonFontGroupBoxContactInfo;
        private System.Windows.Forms.Button buttonColorGroupBoxPersonalInfo;
        private System.Windows.Forms.Button buttonFontGroupBoxPersonalInfo;
        private System.Windows.Forms.Button buttonColorGroupBoxEvaluation;
        private System.Windows.Forms.Button buttonFontGroupBoxEvaluation;
        private System.Windows.Forms.Button buttonColorButtonSubmit;
        private System.Windows.Forms.Button buttonFontButtonSubmit;

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;

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
            this.buttonColorLabelTitle = new System.Windows.Forms.Button();
            this.buttonFontLabelTitle = new System.Windows.Forms.Button();
            this.buttonColorGroupBoxContactInfo = new System.Windows.Forms.Button();
            this.buttonFontGroupBoxContactInfo = new System.Windows.Forms.Button();
            this.buttonColorGroupBoxPersonalInfo = new System.Windows.Forms.Button();
            this.buttonFontGroupBoxPersonalInfo = new System.Windows.Forms.Button();
            this.buttonColorGroupBoxEvaluation = new System.Windows.Forms.Button();
            this.buttonFontGroupBoxEvaluation = new System.Windows.Forms.Button();
            this.buttonColorButtonSubmit = new System.Windows.Forms.Button();
            this.buttonFontButtonSubmit = new System.Windows.Forms.Button();

            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();

            // 
            // buttonColorLabelTitle
            // 
            this.buttonColorLabelTitle.Location = new System.Drawing.Point(20, 20);
            this.buttonColorLabelTitle.Name = "buttonColorLabelTitle";
            this.buttonColorLabelTitle.Size = new System.Drawing.Size(300, 30);
            this.buttonColorLabelTitle.TabIndex = 0;
            this.buttonColorLabelTitle.Text = "Змінити колір заголовку";
            this.buttonColorLabelTitle.UseVisualStyleBackColor = true;
            this.buttonColorLabelTitle.Click += new System.EventHandler(this.buttonColorLabelTitle_Click);

            // 
            // buttonFontLabelTitle
            // 
            this.buttonFontLabelTitle.Location = new System.Drawing.Point(350, 20);
            this.buttonFontLabelTitle.Name = "buttonFontLabelTitle";
            this.buttonFontLabelTitle.Size = new System.Drawing.Size(320, 30);
            this.buttonFontLabelTitle.TabIndex = 1;
            this.buttonFontLabelTitle.Text = "Змінити шрифт заголовку";
            this.buttonFontLabelTitle.UseVisualStyleBackColor = true;
            this.buttonFontLabelTitle.Click += new System.EventHandler(this.buttonFontLabelTitle_Click);

            // 
            // buttonColorGroupBoxContactInfo
            // 
            this.buttonColorGroupBoxContactInfo.Location = new System.Drawing.Point(20, 70);
            this.buttonColorGroupBoxContactInfo.Name = "buttonColorGroupBoxContactInfo";
            this.buttonColorGroupBoxContactInfo.Size = new System.Drawing.Size(300, 30);
            this.buttonColorGroupBoxContactInfo.TabIndex = 2;
            this.buttonColorGroupBoxContactInfo.Text = "Змінити колір Контактної інформації";
            this.buttonColorGroupBoxContactInfo.UseVisualStyleBackColor = true;
            this.buttonColorGroupBoxContactInfo.Click += new System.EventHandler(this.buttonColorGroupBoxContactInfo_Click);

            // 
            // buttonFontGroupBoxContactInfo
            // 
            this.buttonFontGroupBoxContactInfo.Location = new System.Drawing.Point(350, 70);
            this.buttonFontGroupBoxContactInfo.Name = "buttonFontGroupBoxContactInfo";
            this.buttonFontGroupBoxContactInfo.Size = new System.Drawing.Size(320, 30);
            this.buttonFontGroupBoxContactInfo.TabIndex = 3;
            this.buttonFontGroupBoxContactInfo.Text = "Змінити шрифт Контактної інформації";
            this.buttonFontGroupBoxContactInfo.UseVisualStyleBackColor = true;
            this.buttonFontGroupBoxContactInfo.Click += new System.EventHandler(this.buttonFontGroupBoxContactInfo_Click);

            // 
            // buttonColorGroupBoxPersonalInfo
            // 
            this.buttonColorGroupBoxPersonalInfo.Location = new System.Drawing.Point(20, 120);
            this.buttonColorGroupBoxPersonalInfo.Name = "buttonColorGroupBoxPersonalInfo";
            this.buttonColorGroupBoxPersonalInfo.Size = new System.Drawing.Size(300, 30);
            this.buttonColorGroupBoxPersonalInfo.TabIndex = 4;
            this.buttonColorGroupBoxPersonalInfo.Text = "Змінити колір Персональної інформації";
            this.buttonColorGroupBoxPersonalInfo.UseVisualStyleBackColor = true;
            this.buttonColorGroupBoxPersonalInfo.Click += new System.EventHandler(this.buttonColorGroupBoxPersonalInfo_Click);

            // 
            // buttonFontGroupBoxPersonalInfo
            // 
            this.buttonFontGroupBoxPersonalInfo.Location = new System.Drawing.Point(350, 120);
            this.buttonFontGroupBoxPersonalInfo.Name = "buttonFontGroupBoxPersonalInfo";
            this.buttonFontGroupBoxPersonalInfo.Size = new System.Drawing.Size(320, 30);
            this.buttonFontGroupBoxPersonalInfo.TabIndex = 5;
            this.buttonFontGroupBoxPersonalInfo.Text = "Змінити шрифт Персональної інформації";
            this.buttonFontGroupBoxPersonalInfo.UseVisualStyleBackColor = true;
            this.buttonFontGroupBoxPersonalInfo.Click += new System.EventHandler(this.buttonFontGroupBoxPersonalInfo_Click);

            // 
            // buttonColorGroupBoxEvaluation
            // 
            this.buttonColorGroupBoxEvaluation.Location = new System.Drawing.Point(20, 170);
            this.buttonColorGroupBoxEvaluation.Name = "buttonColorGroupBoxEvaluation";
            this.buttonColorGroupBoxEvaluation.Size = new System.Drawing.Size(300, 30);
            this.buttonColorGroupBoxEvaluation.TabIndex = 6;
            this.buttonColorGroupBoxEvaluation.Text = "Змінити колір Оцінки";
            this.buttonColorGroupBoxEvaluation.UseVisualStyleBackColor = true;
            this.buttonColorGroupBoxEvaluation.Click += new System.EventHandler(this.buttonColorGroupBoxEvaluation_Click);

            // 
            // buttonFontGroupBoxEvaluation
            // 
            this.buttonFontGroupBoxEvaluation.Location = new System.Drawing.Point(350, 170);
            this.buttonFontGroupBoxEvaluation.Name = "buttonFontGroupBoxEvaluation";
            this.buttonFontGroupBoxEvaluation.Size = new System.Drawing.Size(320, 30);
            this.buttonFontGroupBoxEvaluation.TabIndex = 7;
            this.buttonFontGroupBoxEvaluation.Text = "Змінити шрифт Оцінки";
            this.buttonFontGroupBoxEvaluation.UseVisualStyleBackColor = true;
            this.buttonFontGroupBoxEvaluation.Click += new System.EventHandler(this.buttonFontGroupBoxEvaluation_Click);

            // 
            // buttonColorButtonSubmit
            // 
            this.buttonColorButtonSubmit.Location = new System.Drawing.Point(20, 220);
            this.buttonColorButtonSubmit.Name = "buttonColorButtonSubmit";
            this.buttonColorButtonSubmit.Size = new System.Drawing.Size(300, 30);
            this.buttonColorButtonSubmit.TabIndex = 8;
            this.buttonColorButtonSubmit.Text = "Змінити колір кнопки Відправити";
            this.buttonColorButtonSubmit.UseVisualStyleBackColor = true;
            this.buttonColorButtonSubmit.Click += new System.EventHandler(this.buttonColorButtonSubmit_Click);

            // 
            // buttonFontButtonSubmit
            // 
            this.buttonFontButtonSubmit.Location = new System.Drawing.Point(350, 220);
            this.buttonFontButtonSubmit.Name = "buttonFontButtonSubmit";
            this.buttonFontButtonSubmit.Size = new System.Drawing.Size(320, 30);
            this.buttonFontButtonSubmit.TabIndex = 9;
            this.buttonFontButtonSubmit.Text = "Змінити шрифт кнопки Відправити";
            this.buttonFontButtonSubmit.UseVisualStyleBackColor = true;
            this.buttonFontButtonSubmit.Click += new System.EventHandler(this.buttonFontButtonSubmit_Click);

            // 
            // ConfigForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.buttonColorLabelTitle);
            this.Controls.Add(this.buttonFontLabelTitle);
            this.Controls.Add(this.buttonColorGroupBoxContactInfo);
            this.Controls.Add(this.buttonFontGroupBoxContactInfo);
            this.Controls.Add(this.buttonColorGroupBoxPersonalInfo);
            this.Controls.Add(this.buttonFontGroupBoxPersonalInfo);
            this.Controls.Add(this.buttonColorGroupBoxEvaluation);
            this.Controls.Add(this.buttonFontGroupBoxEvaluation);
            this.Controls.Add(this.buttonColorButtonSubmit);
            this.Controls.Add(this.buttonFontButtonSubmit);
            this.Name = "ConfigForm";
            this.Text = "Налаштування";
        }
    }
}
