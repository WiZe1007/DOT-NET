namespace Task__9 // Оголошення простору імен Task__9
{
    partial class Form1 // Часткове оголошення класу Form1
    {
        private System.ComponentModel.IContainer components = null; // Змінна для зберігання компонентів форми
        private System.Windows.Forms.ToolStrip toolStrip1; // Змінна для панелі інструментів
        private System.Windows.Forms.ToolStripButton toolStripButton1; // Змінна для кнопки 1 на панелі інструментів
        private System.Windows.Forms.ToolStripButton toolStripButton2; // Змінна для кнопки 2 на панелі інструментів
        private System.Windows.Forms.ToolStripButton toolStripButton3; // Змінна для кнопки 3 на панелі інструментів
        private System.Windows.Forms.ToolStripButton toolStripButton4; // Змінна для кнопки 4 на панелі інструментів

        protected override void Dispose(bool disposing) // Метод для очищення ресурсів форми
        {
            if (disposing && (components != null)) // Перевірка, чи потрібно звільняти ресурси компонентів
            {
                components.Dispose(); // Звільнення ресурсів компонентів
            }
            base.Dispose(disposing); // Виклик базового методу Dispose
        }

        private void InitializeComponent() // Метод для ініціалізації компонентів форми
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip(); // Ініціалізація панелі інструментів
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton(); // Ініціалізація кнопки 1
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton(); // Ініціалізація кнопки 2
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton(); // Ініціалізація кнопки 3
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton(); // Ініціалізація кнопки 4
            this.toolStrip1.SuspendLayout(); // Призупинення автоматичного розташування елементів панелі
            this.SuspendLayout(); // Призупинення автоматичного розташування елементів форми

            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1, // Додавання кнопки 1 на панель інструментів
            this.toolStripButton2, // Додавання кнопки 2 на панель інструментів
            this.toolStripButton3, // Додавання кнопки 3 на панель інструментів
            this.toolStripButton4}); // Додавання кнопки 4 на панель інструментів
            this.toolStrip1.Location = new System.Drawing.Point(0, 0); // Встановлення координат для панелі
            this.toolStrip1.Name = "toolStrip1"; // Встановлення імені панелі інструментів
            this.toolStrip1.Size = new System.Drawing.Size(800, 25); // Встановлення розмірів панелі інструментів
            this.toolStrip1.TabIndex = 0; // Встановлення індексу табуляції
            this.toolStrip1.Text = "toolStrip1"; // Встановлення текстового імені для панелі інструментів

            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; // Відображення кнопки як зображення
            this.toolStripButton1.Image = System.Drawing.Image.FromFile(@"C:\Users\nemof\source\repos\Task__9\Task__9\Icon1.png"); // Завантаження зображення для кнопки 1
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta; // Встановлення прозорого кольору для зображення
            this.toolStripButton1.Name = "toolStripButton1"; // Встановлення імені кнопки 1
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22); // Встановлення розміру кнопки 1
            this.toolStripButton1.Text = "Tool1"; // Встановлення текстового підпису кнопки 1

            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; // Відображення кнопки як зображення
            this.toolStripButton2.Image = System.Drawing.Image.FromFile(@"C:\Users\nemof\source\repos\Task__9\Task__9\Icon2.png"); // Завантаження зображення для кнопки 2
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta; // Встановлення прозорого кольору для зображення
            this.toolStripButton2.Name = "toolStripButton2"; // Встановлення імені кнопки 2
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22); // Встановлення розміру кнопки 2
            this.toolStripButton2.Text = "Tool2"; // Встановлення текстового підпису кнопки 2

            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; // Відображення кнопки як зображення
            this.toolStripButton3.Image = System.Drawing.Image.FromFile(@"C:\Users\nemof\source\repos\Task__9\Task__9\Icon3.png"); // Завантаження зображення для кнопки 3
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta; // Встановлення прозорого кольору для зображення
            this.toolStripButton3.Name = "toolStripButton3"; // Встановлення імені кнопки 3
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22); // Встановлення розміру кнопки 3
            this.toolStripButton3.Text = "Tool3"; // Встановлення текстового підпису кнопки 3

            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image; // Відображення кнопки як зображення
            this.toolStripButton4.Image = System.Drawing.Image.FromFile(@"C:\Users\nemof\source\repos\Task__9\Task__9\Icon4.png"); // Завантаження зображення для кнопки 4
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta; // Встановлення прозорого кольору для зображення
            this.toolStripButton4.Name = "toolStripButton4"; // Встановлення імені кнопки 4
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22); // Встановлення розміру кнопки 4
            this.toolStripButton4.Text = "Tool4"; // Встановлення текстового підпису кнопки 4

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Встановлення масштабу елементів управління
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Встановлення режиму масштабування
            this.ClientSize = new System.Drawing.Size(800, 450); // Встановлення розмірів форми
            this.Controls.Add(this.toolStrip1); // Додавання панелі інструментів на форму
            this.Name = "Form1"; // Встановлення імені форми
            this.Text = "Task 9"; // Встановлення заголовка вікна

            this.toolStrip1.ResumeLayout(false); // Відновлення автоматичного розташування елементів панелі
            this.toolStrip1.PerformLayout(); // Виконання автоматичного розташування елементів панелі
            this.ResumeLayout(false); // Відновлення автоматичного розташування елементів форми
            this.PerformLayout(); // Виконання автоматичного розташування елементів форми
        }
    }
}
