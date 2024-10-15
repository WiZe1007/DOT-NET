namespace Task_01
{
    partial class Form1
    {
        // Контейнер для компонентів форми
        private System.ComponentModel.IContainer components = null;

        // Label для відображення тексту
        private Label displayLabel;

        // Панель для відображення label
        private Panel displayPanel;

        // Таймер для контролю часу
        private System.Windows.Forms.Timer displayTimer;

        // Вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Звільнення ресурсів, якщо вони не нульові
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Ініціалізація компонентів форми
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.displayLabel = new System.Windows.Forms.Label();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            // 
            // displayPanel
            // 
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Рамка
            this.displayPanel.Controls.Add(this.displayLabel); // Додавання label до панелі
            this.displayPanel.Location = new System.Drawing.Point(250, 10); // Встановлення позиції панелі
            this.displayPanel.Name = "displayPanel"; // Ім'я панелі
            this.displayPanel.Size = new System.Drawing.Size(140, 50); // Розміри панелі
            this.displayPanel.TabIndex = 0; // Індекс для табуляції
            this.displayPanel.Visible = false; // Початково невидима

            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true; 
            this.displayLabel.Location = new System.Drawing.Point(10, 15); // Позиція label в панелі
            this.displayLabel.Name = "displayLabel"; // Ім'я label
            this.displayLabel.Size = new System.Drawing.Size(0, 13); // Розміри label
            this.displayLabel.TabIndex = 0; // Індекс для табуляції

            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 3000; 
            this.displayTimer.Tick += new System.EventHandler(DisplayTimer_Tick); // Обробник події таймера

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Масштаб
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Режим масштабу
            this.ClientSize = new System.Drawing.Size(400, 300); 
            this.Controls.Add(this.displayPanel); // Додавання панелі до форми
            this.Name = "MainForm"; 
            this.Text = "Task 1"; 
            this.ResumeLayout(false); // Завершення компоновки
        }

        #endregion
    }
}
