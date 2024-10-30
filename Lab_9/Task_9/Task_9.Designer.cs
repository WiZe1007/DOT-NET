namespace Lab_9
{
    partial class Task_9
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1; // Група
        private System.Windows.Forms.ComboBox comboBoxTourType; // Вибір туру
        private System.Windows.Forms.Label labelQuantity; // Мітка кількості
        private System.Windows.Forms.TextBox textBoxQuantity; // Введення кількості
        private System.Windows.Forms.Button buttonCalculate; // Кнопка
        private System.Windows.Forms.Label labelResult; // Результат

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
            this.comboBoxTourType = new System.Windows.Forms.ComboBox(); // Ініціалізація
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label(); // Ініціалізація результату
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // groupBox1
            this.groupBox1.Controls.Add(this.comboBoxTourType); // Додаємо до групи
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип туру"; // Заголовок

            // comboBoxTourType
            this.comboBoxTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTourType.FormattingEnabled = true;
            this.comboBoxTourType.Items.AddRange(new object[] {
            "Економ (5 днів)",
            "Стандарт (7 днів)",
            "Преміум (10 днів)"});
            this.comboBoxTourType.Location = new System.Drawing.Point(10, 30);
            this.comboBoxTourType.Name = "comboBoxTourType";
            this.comboBoxTourType.Size = new System.Drawing.Size(180, 21);
            this.comboBoxTourType.TabIndex = 1;

            // labelQuantity
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 125);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(75, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Кількість осіб:"; // Текст

            // textBoxQuantity
            this.textBoxQuantity.Location = new System.Drawing.Point(140, 122);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(80, 20);
            this.textBoxQuantity.TabIndex = 5;

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(12, 150);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(80, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "ОК"; // Текст кнопки
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click); // Подія

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 200); // Позиція
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13); // Порожній текст
            this.labelResult.TabIndex = 7; // Таб-індекс

            // Form9
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.groupBox1); // Додаємо групу
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult); // Додаємо результат
            this.Name = "Form9"; // Ім'я
            this.Text = "Task 9"; // Заголовок
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
