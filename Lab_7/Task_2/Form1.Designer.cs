namespace Task_02
{
    partial class Form1
    {
        // Компоненти для форми
        private System.ComponentModel.IContainer components = null;
        private Label displayLabel; // Мітка для відображення тексту
        private Panel displayPanel; // Панель, на якій розташована мітка
        private System.Windows.Forms.Timer displayTimer; // Таймер для контролю часу відображення

        protected override void Dispose(bool disposing)
        {
            // Звільнення ресурсів, якщо це необхідно
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.displayLabel = new System.Windows.Forms.Label();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // Налаштування панелі для відображення
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Controls.Add(this.displayLabel);
            this.displayPanel.Location = new System.Drawing.Point(250, 10);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(140, 50);
            this.displayPanel.TabIndex = 0;
            this.displayPanel.Visible = false; // Панель початково невидима

            // Налаштування мітки для тексту
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(10, 15);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 0;

            // Налаштування таймера
            this.displayTimer.Interval = 3000; // Встановлення інтервалу на 3 секунди
            this.displayTimer.Tick += new System.EventHandler(this.DisplayTimer_Tick); // Додавання обробника події

            // Налаштування основної форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.displayPanel); // Додавання панелі на форму
            this.Name = "MainForm";
            this.Text = "Task 2"; // Заголовок форми
            this.ResumeLayout(false);
        }

        #endregion
    }
}
