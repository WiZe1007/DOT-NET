namespace Lab_9
{
    partial class Task_7
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult; 

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label(); // Ініціалізація Label для результату
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // Група радіокнопок для вибору туру
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип туру";

            // Радіокнопка для економ-туру
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Економ (5 днів)";
            this.radioButton1.UseVisualStyleBackColor = true;

            // Радіокнопка для стандарт-туру
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Стандарт (7 днів)";
            this.radioButton2.UseVisualStyleBackColor = true;

            // Радіокнопка для преміум-туру
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Преміум (10 днів)";
            this.radioButton3.UseVisualStyleBackColor = true;

            // Мітка для кількості осіб
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 125);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(75, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Кількість осіб:";

            // Поле для введення кількості осіб
            this.textBoxQuantity.Location = new System.Drawing.Point(140, 122);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(80, 20);
            this.textBoxQuantity.TabIndex = 5;

            // Кнопка для обчислення
            this.buttonCalculate.Location = new System.Drawing.Point(12, 150);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(80, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "ОК";
            this.buttonCalculate.UseVisualStyleBackColor = true;

            // Мітка для відображення результату
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 200); // Позиція для labelResult
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13); // Початковий текст порожній
            this.labelResult.TabIndex = 7; // Таб-індекс

            // Налаштування форми
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult); // Додавання Label до форми
            this.Name = "Form7";
            this.Text = "Task 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
