﻿namespace Lab_9
{
    partial class Task_1
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1; // Підпис для вводу суми
        private System.Windows.Forms.Label label2; // Підпис для відображення результату
        private System.Windows.Forms.TextBox textBox1; // Поле для вводу суми
        private System.Windows.Forms.Button button1; // Кнопка для підтвердження

        // Вивільнення ресурсів
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
            this.SuspendLayout();

            // label1: Налаштування підпису для вводу суми
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума у грн.";

            // textBox1: Налаштування поля для вводу
            this.textBox1.Location = new System.Drawing.Point(100, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;

            // label2: Налаштування підпису для відображення результату
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;

            // button1: Налаштування кнопки
            this.button1.Enabled = false; // Кнопка спочатку неактивна
            this.button1.Location = new System.Drawing.Point(100, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;

            // Form1: Налаштування основних параметрів форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task 1"; // Заголовок форми
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
