namespace Lab_10
{
    partial class Task_5
    {
        private System.ComponentModel.IContainer components = null;

        // Очищення ресурсів
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label(); // Для хвилин
            this.label2 = new System.Windows.Forms.Label(); // Для двокрапки
            this.label3 = new System.Windows.Forms.Label(); // Для секунд
            this.buttonStart = new System.Windows.Forms.Button(); // Кнопка старт
            this.buttonStop = new System.Windows.Forms.Button(); // Кнопка стоп
            this.timer1 = new System.Windows.Forms.Timer(this.components); // Таймер
            this.SuspendLayout();

            // Налаштування label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";

            // Налаштування label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(109, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";

            // Налаштування label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(141, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "00";

            // Налаштування buttonStart
            this.buttonStart.Location = new System.Drawing.Point(50, 100);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);

            // Налаштування buttonStop
            this.buttonStop.Location = new System.Drawing.Point(131, 100);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);

            // Налаштування таймера
            this.timer1.Interval = 1000; // Інтервал 1 секунда
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Task 5";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
    }
}
