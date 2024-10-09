namespace Task__7
{
    partial class Form1
    {
        // Змінна для зберігання компонентів форми
        private System.ComponentModel.IContainer components = null;
        // Елемент меню
        private System.Windows.Forms.MenuStrip menuStrip1;

        // Метод для вивільнення ресурсів
        protected override void Dispose(bool disposing)
        {
            // Якщо disposing = true, вивільняємо компоненти
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            // Виклик базового методу Dispose
            base.Dispose(disposing);
        }

        // Метод для ініціалізації компонентів форми
        private void InitializeComponent()
        {
            // Ініціалізуємо меню
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();

            // MenuStrip
            // Додаємо елементи меню до menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                CreateMenuItem("Item1", new string[] { "Item11", "Item12", "Item13", "Item14" }), // Перший пункт меню з підпунктами
                CreateMenuItem("Item2", new string[] { "Item21", "Item22", "Item23" }),          // Другий пункт меню з підпунктами
                CreateMenuItem("Item3", new string[] { "Item31", "Item32", "Item33", "Item34" }, new (string, string[])[] { // Третій пункт меню з підпунктами та підменю третього рівня
                    ("Item32", new string[] { "Item321", "Item322", "Item323" }),
                    ("Item33", new string[] { "Item331", "Item332", "Item333" })
                }),
                CreateMenuItem("Item4", new string[] { "Item41", "Item42", "Item43", "Item44", "Item45" }, new (string, string[])[] { // Четвертий пункт меню з підпунктами та підменю третього рівня
                    ("Item44", new string[] { "Item441", "Item442", "Item443", "Item444", "Item445", "Item446" })
                })
            });
            // Задаємо позицію меню в формі
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            // Ім'я для MenuStrip
            this.menuStrip1.Name = "menuStrip1";
            // Задаємо розмір MenuStrip
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            // Таб індекс для MenuStrip
            this.menuStrip1.TabIndex = 0;
            // Текст MenuStrip
            this.menuStrip1.Text = "menuStrip1";

            // Form1
            // Задаємо параметри масштабу для форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Задаємо розмір клієнтської області форми
            this.ClientSize = new System.Drawing.Size(800, 450);
            // Додаємо MenuStrip до елементів форми
            this.Controls.Add(this.menuStrip1);
            // Встановлюємо головне меню для форми
            this.MainMenuStrip = this.menuStrip1;
            // Встановлюємо ім'я форми
            this.Name = "Form1";
            // Встановлюємо заголовок форми
            this.Text = "Task 7";
            // Завершуємо зміни у компонуванні форми
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Метод для створення пункту меню з підпунктами і підменю третього рівня
        private ToolStripMenuItem CreateMenuItem(string text, string[] subItems, (string, string[])[] subSubItems = null)
        {
            // Створюємо новий пункт меню з текстом
            ToolStripMenuItem menuItem = new ToolStripMenuItem(text);
            // Для кожного підпункту додаємо його до пункту меню
            foreach (var subItem in subItems)
            {
                ToolStripMenuItem subMenuItem = new ToolStripMenuItem(subItem);
                menuItem.DropDownItems.Add(subMenuItem);

                // Додаємо розділи 3 рівня, якщо вони є для цього пункту 2 рівня
                if (subSubItems != null)
                {
                    // Знаходимо підменю для поточного підпункту
                    var subSubItemEntry = Array.Find(subSubItems, entry => entry.Item1 == subItem);
                    // Якщо знайдено підменю для поточного підпункту, додаємо їх
                    if (subSubItemEntry.Item1 != null)
                    {
                        foreach (var subSubItem in subSubItemEntry.Item2)
                        {
                            subMenuItem.DropDownItems.Add(subSubItem);
                        }
                    }
                }
            }
            // Повертаємо створений пункт меню
            return menuItem;
        }
    }
}
