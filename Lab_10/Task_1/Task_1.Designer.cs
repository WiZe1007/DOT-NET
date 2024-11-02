using System;
using System.Windows.Forms;

namespace Lab_10
{
    partial class Task_1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1; // Зображення
        private Panel panel1; // Панель кнопок
        private Button buttonFolder; // Вибір папки
        private Button buttonPrevious; // Попереднє зображення
        private Button buttonNext; // Наступне зображення

        // Звільнення ресурсів
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // Налаштування pictureBox1
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top; // Вгорі
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // Масштабування
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // Налаштування panel1
            this.panel1.Controls.Add(this.buttonFolder);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom; // Внизу
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;

            // Налаштування buttonFolder
            this.buttonFolder.Location = new System.Drawing.Point(12, 15);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.Text = "Папка";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += (s, e) => buttonFolder_Click(); // Вибір папки

            // Налаштування buttonPrevious
            this.buttonPrevious.Location = new System.Drawing.Point(362, 15);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(50, 23);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<<"; // Текст
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += (s, e) => buttonPrevious_Click(); // Попереднє зображення

            // Налаштування buttonNext
            this.buttonNext.Location = new System.Drawing.Point(418, 15);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">>"; // Текст
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += (s, e) => buttonNext_Click(); // Наступне зображення

            // Налаштування Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1); // Додавання панелі
            this.Controls.Add(this.pictureBox1); // Додавання PictureBox
            this.Name = "Form1";
            this.Text = "Task 1"; // Заголовок
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
