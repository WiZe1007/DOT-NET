using System;
using System.Windows.Forms;

namespace Lab_10
{
    partial class Task_2
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1; // Зображення
        private Panel panel1; // Панель кнопок
        private Button buttonFolder; // Вибір папки
        private Button buttonPrevious; // Попереднє зображення
        private Button buttonNext; // Наступне зображення
        private Button buttonStartStop; // Старт/стоп
        private TrackBar trackBarSpeed; // Швидкість
        private TextBox textBoxSpeed; // Введення швидкості
        private System.Windows.Forms.Timer timer; // Таймер

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
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // panel1
            this.panel1.Controls.Add(this.buttonFolder);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonStartStop);
            this.panel1.Controls.Add(this.trackBarSpeed);
            this.panel1.Controls.Add(this.textBoxSpeed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 1;

            // buttonFolder
            this.buttonFolder.Location = new System.Drawing.Point(12, 15);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.Text = "Папка";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new EventHandler(this.buttonFolder_Click);

            // buttonPrevious
            this.buttonPrevious.Location = new System.Drawing.Point(362, 15);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(50, 23);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new EventHandler(this.buttonPrevious_Click);

            // buttonNext
            this.buttonNext.Location = new System.Drawing.Point(418, 15);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new EventHandler(this.buttonNext_Click);

            // buttonStartStop
            this.buttonStartStop.Location = new System.Drawing.Point(96, 15);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.Text = "Почати";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new EventHandler(this.buttonStartStop_Click);

            // trackBarSpeed
            this.trackBarSpeed.Location = new System.Drawing.Point(200, 15);
            this.trackBarSpeed.Maximum = 10000; // Макс. швидкість
            this.trackBarSpeed.Minimum = 0; // Мін. швидкість
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(150, 45);
            this.trackBarSpeed.TabIndex = 4;
            this.trackBarSpeed.TickFrequency = 500;
            this.trackBarSpeed.Value = 1000; // Початкова швидкість
            this.trackBarSpeed.Scroll += new EventHandler(this.trackBarSpeed_Scroll);

            // textBoxSpeed
            this.textBoxSpeed.Location = new System.Drawing.Point(250, 50);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 5;
            this.textBoxSpeed.Text = "1000"; // За замовчуванням
            this.textBoxSpeed.TextChanged += new EventHandler(this.textBoxSpeed_TextChanged);

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Task 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
