namespace Lab_9
{
    partial class Task_4
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1; // Мітка
        private System.Windows.Forms.TextBox textBox1; // Поле вводу
        private System.Windows.Forms.Button button1; // Кнопка
        private System.Windows.Forms.Label resultLabel; // Мітка для результату
        private System.Windows.Forms.ComboBox conversionDirectionComboBox; // Комбо-бокс для вибору напрямку конвертації

        // Вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.conversionDirectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // Налаштування label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Значення";

            // Налаштування textBox1
            this.textBox1.Location = new System.Drawing.Point(100, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // Налаштування comboBox
            this.conversionDirectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conversionDirectionComboBox.Items.AddRange(new object[] {
            "Кілометри в пункти",
            "Пункти в кілометри"});
            this.conversionDirectionComboBox.Location = new System.Drawing.Point(100, 60);
            this.conversionDirectionComboBox.Name = "conversionDirectionComboBox";
            this.conversionDirectionComboBox.Size = new System.Drawing.Size(140, 21);
            this.conversionDirectionComboBox.TabIndex = 2;
            this.conversionDirectionComboBox.SelectedIndex = 0;

            // Налаштування button1
            this.button1.Enabled = false; // Деактивована до вводу значення
            this.button1.Location = new System.Drawing.Point(40, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Налаштування resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(25, 140);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conversionDirectionComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Task 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
