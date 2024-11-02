namespace Lab_10
{
    partial class Task_6
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // Контейнер
            this.label1 = new System.Windows.Forms.Label(); // Мітка часу
            this.buttonToggle = new System.Windows.Forms.Button(); // Кнопка
            this.timer1 = new System.Windows.Forms.Timer(this.components); // Таймер
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown(); // Вибір хвилин
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown(); // Вибір секунд
            this.groupBox1 = new System.Windows.Forms.GroupBox(); // Група
            this.labelMinutes = new System.Windows.Forms.Label(); // Мітка "Хвилин"
            this.labelSeconds = new System.Windows.Forms.Label(); // Мітка "Секунд"

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit(); // ініціалізація 1
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit(); // ініціалізація 2
            this.groupBox1.SuspendLayout(); // Зупинити розкладку групи
            this.SuspendLayout(); // Зупинити розкладку форми

            // label1 відображення часу
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";

            // buttonToggle кнопка старту/зупинки
            this.buttonToggle.Location = new System.Drawing.Point(120, 140);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 1;
            this.buttonToggle.Text = "Старт";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);

            // timer1 таймер на 1 секунду
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // groupBox1 налаштування інтервалу
            this.groupBox1.Controls.Add(this.labelMinutes);
            this.groupBox1.Controls.Add(this.labelSeconds);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інтервал";

            // labelMinutes текст "Хвилин"
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(10, 25);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(42, 13);
            this.labelMinutes.TabIndex = 5;
            this.labelMinutes.Text = "Хвилин:";

            // numericUpDown1 вибір хвилин
            this.numericUpDown1.Location = new System.Drawing.Point(60, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 2;

            // labelSeconds текст "Секунд"
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(120, 25);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(43, 13);
            this.labelSeconds.TabIndex = 6;
            this.labelSeconds.Text = "Секунд:";

            // numericUpDown2 вибір секунд
            this.numericUpDown2.Location = new System.Drawing.Point(170, 23);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 3;

            // Form6 налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Task 6";

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit(); // закінчення ініц. 1
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit(); // закінчення ініц. 2
            this.groupBox1.ResumeLayout(false); // відновити розкладку групи
            this.groupBox1.PerformLayout(); // виконати розкладку
            this.ResumeLayout(false); // відновити розкладку форми
            this.PerformLayout(); // виконати розкладку
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
    }
}
