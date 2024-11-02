namespace Lab_10
{
    partial class Task_3
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

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            this.listBoxImages = new System.Windows.Forms.ListBox(); // Список
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox(); // Попередній перегляд
            this.buttonSelectFolder = new System.Windows.Forms.Button(); // Вибір папки
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true; 
            this.listBoxImages.Location = new System.Drawing.Point(12, 12);
            this.listBoxImages.Name = "listBoxImages"; 
            this.listBoxImages.Size = new System.Drawing.Size(150, 290);
            this.listBoxImages.TabIndex = 0; // Індекс
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged); // Вибір
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(170, 12);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(400, 290);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Режим
            this.pictureBoxPreview.TabIndex = 1; // Індекс
            this.pictureBoxPreview.TabStop = false; // Без фокусу
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(12, 310);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFolder.TabIndex = 2; // Індекс
            this.buttonSelectFolder.Text = "Папка...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true; // Стиль
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click); // Натискання
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.listBoxImages);
            this.Name = "Form3";
            this.Text = "Task 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false); // Завершення
        }

        // Оголошення компонентів
        private System.Windows.Forms.ListBox listBoxImages; // Список
        private System.Windows.Forms.PictureBox pictureBoxPreview; // Перегляд
        private System.Windows.Forms.Button buttonSelectFolder; // Кнопка
    }
}
