namespace Task__8
{
    partial class Form1
    {
        // Оголошення змінної для компонентів форми
        private System.ComponentModel.IContainer components = null;
        // Оголошення мітки (Label) 1
        private Label label1;
        // Оголошення мітки (Label) 2
        private Label label2;
        // Оголошення мітки (Label) 3
        private Label label3;
        // Оголошення контекстного меню (ContextMenuStrip)
        private ContextMenuStrip contextMenu;

        // Метод для звільнення ресурсів (Dispose pattern)
        protected override void Dispose(bool disposing)
        {
            // Якщо звільняються керовані ресурси, звільнити компоненти
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            // Виклик базового методу Dispose
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Метод для ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Ініціалізація контейнера компонентів
            this.components = new System.ComponentModel.Container();
            // Ініціалізація контекстного меню з прив'язкою до компонентів форми
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            // Ініціалізація Label1
            this.label1 = new System.Windows.Forms.Label();
            // Ініціалізація Label2
            this.label2 = new System.Windows.Forms.Label();
            // Ініціалізація Label3
            this.label3 = new System.Windows.Forms.Label();
            // Призупинення компоновки форми для оптимізації налаштувань
            this.SuspendLayout();

            // Налаштування властивостей Label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label 1";

            // Налаштування властивостей Label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label 2";

            // Налаштування властивостей Label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Label 3";

            // Налаштування властивостей форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            // Додавання міток до колекції контролів форми
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            // Вказання імені форми
            this.Name = "Form1";
            // Встановлення заголовка форми
            this.Text = "Task 8";
            // Відновлення компоновки після змін
            this.ResumeLayout(false);
            // Оновлення макету для правильної відображення
            this.PerformLayout();
        }

        #endregion
    }
}
