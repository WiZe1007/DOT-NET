namespace Lab_9
{
    partial class Task_2
    {
        private System.ComponentModel.IContainer components = null; // Контейнери компонентів
        private System.Windows.Forms.Label label1; // Мітка для вводу суми
        private System.Windows.Forms.Label label2; // Мітка для відображення результату
        private System.Windows.Forms.TextBox textBox1; // Поле для вводу значення
        private System.Windows.Forms.Button button1; // Кнопка для виконання дії
        private System.Windows.Forms.RadioButton radioButtonToKZT; // Радіокнопка для конвертації в теньге
        private System.Windows.Forms.RadioButton radioButtonToUAH; // Радіокнопка для конвертації в гривні

        // Очищення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Ініціалізація компонентів форми
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonToKZT = new System.Windows.Forms.RadioButton();
            this.radioButtonToUAH = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();

            // label1 - Мітка для введення суми
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума у грн.";

            // textBox1 - Поле вводу суми
            this.textBox1.Location = new System.Drawing.Point(100, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // label2 - Мітка для результату
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;

            // button1 - Кнопка для підтвердження
            this.button1.Enabled = false; // Спочатку неактивна
            this.button1.Location = new System.Drawing.Point(100, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // radioButtonToKZT - Конвертація з гривні в теньге
            this.radioButtonToKZT.AutoSize = true;
            this.radioButtonToKZT.Checked = true; // За замовчуванням
            this.radioButtonToKZT.Location = new System.Drawing.Point(25, 60);
            this.radioButtonToKZT.Name = "radioButtonToKZT";
            this.radioButtonToKZT.Size = new System.Drawing.Size(90, 17);
            this.radioButtonToKZT.TabIndex = 4;
            this.radioButtonToKZT.TabStop = true;
            this.radioButtonToKZT.Text = "Грн -> Теньге";
            this.radioButtonToKZT.UseVisualStyleBackColor = true;

            // radioButtonToUAH - Конвертація з теньге в гривні
            this.radioButtonToUAH.AutoSize = true;
            this.radioButtonToUAH.Location = new System.Drawing.Point(130, 60);
            this.radioButtonToUAH.Name = "radioButtonToUAH";
            this.radioButtonToUAH.Size = new System.Drawing.Size(90, 17);
            this.radioButtonToUAH.TabIndex = 5;
            this.radioButtonToUAH.Text = "Теньге -> Грн";
            this.radioButtonToUAH.UseVisualStyleBackColor = true;

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.radioButtonToUAH);
            this.Controls.Add(this.radioButtonToKZT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Task 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
