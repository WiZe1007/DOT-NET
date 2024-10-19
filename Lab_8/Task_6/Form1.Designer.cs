namespace Task_06
{
    partial class Form1
    {
        // Компоненти форми
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;

        // Вивільнення ресурсів
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
            // Ініціалізація меню
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();

            // Додавання елементів меню
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                CreateMenuItem("Item1", new string[] { "Item11", "Item12", "Item13", "Item14" }), // Пункт 1
                CreateMenuItem("Item2", new string[] { "Item21", "Item22", "Item23" }),          // Пункт 2
                CreateMenuItem("Item3", new string[] { "Item31", "Item32", "Item33", "Item34" }, new (string, string[])[] {
                    ("Item32", new string[] { "Item321", "Item322", "Item323" }), // Підменю 1
                    ("Item33", new string[] { "Item331", "Item332", "Item333" })  // Підменю 2
                }),
                CreateMenuItem("Item4", new string[] { "Item41", "Item42", "Item43", "Item44", "Item45" }, new (string, string[])[] {
                    ("Item44", new string[] { "Item441", "Item442", "Item443", "Item444", "Item445", "Item446" }) // Підменю 3
                })
            });

            // Налаштування MenuStrip
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // Налаштування форми
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Task 6";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Створення пункту меню з підпунктами
        private ToolStripMenuItem CreateMenuItem(string text, string[] subItems, (string, string[])[] subSubItems = null)
        {
            // Основний пункт меню
            ToolStripMenuItem menuItem = new ToolStripMenuItem(text);
            foreach (var subItem in subItems)
            {
                ToolStripMenuItem subMenuItem = new ToolStripMenuItem(subItem);
                menuItem.DropDownItems.Add(subMenuItem);

                // Додавання підменю
                if (subSubItems != null)
                {
                    var subSubItemEntry = Array.Find(subSubItems, entry => entry.Item1 == subItem);
                    if (subSubItemEntry.Item1 != null)
                    {
                        foreach (var subSubItem in subSubItemEntry.Item2)
                        {
                            subMenuItem.DropDownItems.Add(subSubItem);
                        }
                    }
                }
            }
            return menuItem; // Повертання пункт меню
        }
    }
}
