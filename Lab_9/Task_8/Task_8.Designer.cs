namespace Lab_9
{
    partial class Task_8
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1; // Група для типів туру
        private System.Windows.Forms.RadioButton radioButton1; // Економ
        private System.Windows.Forms.RadioButton radioButton2; // Стандарт
        private System.Windows.Forms.RadioButton radioButton3; // Преміум
        private System.Windows.Forms.Label labelQuantity; // Мітка для кількості
        private System.Windows.Forms.TextBox textBoxQuantity; // Поле для вводу кількості
        private System.Windows.Forms.Button buttonCalculate; // Кнопка розрахунку
        private System.Windows.Forms.GroupBox groupBoxPricingType; // Група для типу ціни
        private System.Windows.Forms.RadioButton radioButtonStandard; // Звичайна ціна
        private System.Windows.Forms.RadioButton radioButtonRetail; // Роздрібна ціна
        private System.Windows.Forms.RadioButton radioButtonWholesale; // Оптова ціна
        private System.Windows.Forms.Label labelResult; // Мітка для результату

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxPricingType = new System.Windows.Forms.GroupBox();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonRetail = new System.Windows.Forms.RadioButton();
            this.radioButtonWholesale = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label(); // Ініціалізація для результату

            this.groupBox1.SuspendLayout();
            this.groupBoxPricingType.SuspendLayout();
            this.SuspendLayout();

            // Налаштування групи типів туру
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип туру";

            // Налаштування радіокнопок типів туру
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Економ (5 днів)";
            this.radioButton1.UseVisualStyleBackColor = true;

            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Стандарт (7 днів)";
            this.radioButton2.UseVisualStyleBackColor = true;

            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Преміум (10 днів)";
            this.radioButton3.UseVisualStyleBackColor = true;

            // Налаштування групи типів ціни
            this.groupBoxPricingType.Controls.Add(this.radioButtonStandard);
            this.groupBoxPricingType.Controls.Add(this.radioButtonRetail);
            this.groupBoxPricingType.Controls.Add(this.radioButtonWholesale);
            this.groupBoxPricingType.Location = new System.Drawing.Point(12, 118);
            this.groupBoxPricingType.Name = "groupBoxPricingType";
            this.groupBoxPricingType.Size = new System.Drawing.Size(200, 90);
            this.groupBoxPricingType.TabIndex = 7;
            this.groupBoxPricingType.TabStop = false;
            this.groupBoxPricingType.Text = "Тип ціни";

            // Налаштування радіокнопок типів ціни
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(10, 20);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(72, 17);
            this.radioButtonStandard.TabIndex = 8;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Звичайна";
            this.radioButtonStandard.UseVisualStyleBackColor = true;

            this.radioButtonRetail.AutoSize = true;
            this.radioButtonRetail.Location = new System.Drawing.Point(10, 40);
            this.radioButtonRetail.Name = "radioButtonRetail";
            this.radioButtonRetail.Size = new System.Drawing.Size(68, 17);
            this.radioButtonRetail.TabIndex = 9;
            this.radioButtonRetail.TabStop = true;
            this.radioButtonRetail.Text = "Роздрібна";
            this.radioButtonRetail.UseVisualStyleBackColor = true;

            this.radioButtonWholesale.AutoSize = true;
            this.radioButtonWholesale.Location = new System.Drawing.Point(10, 60);
            this.radioButtonWholesale.Name = "radioButtonWholesale";
            this.radioButtonWholesale.Size = new System.Drawing.Size(60, 17);
            this.radioButtonWholesale.TabIndex = 10;
            this.radioButtonWholesale.TabStop = true;
            this.radioButtonWholesale.Text = "Оптова";
            this.radioButtonWholesale.UseVisualStyleBackColor = true;

            // Налаштування мітки кількості
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 220);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(75, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Кількість осіб:";

            // Налаштування поля для вводу кількості
            this.textBoxQuantity.Location = new System.Drawing.Point(140, 217);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(80, 20);
            this.textBoxQuantity.TabIndex = 5;

            // Налаштування кнопки для розрахунку
            this.buttonCalculate.Location = new System.Drawing.Point(12, 250);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(80, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "ОК";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // Налаштування мітки результату
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 290);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 8; // Для відображення результату

            // Налаштування форми
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPricingType);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult); // Додано labelResult
            this.Name = "Form8";
            this.Text = "Task 8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPricingType.ResumeLayout(false);
            this.groupBoxPricingType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
