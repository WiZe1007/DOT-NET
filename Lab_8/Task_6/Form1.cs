using System;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Додавання обробника подій до підпунктів меню
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                AddClickEventToMenuItems(menuItem);
            }
        }

        // Рекурсивний метод для додавання обробників подій
        private void AddClickEventToMenuItems(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
            {
                // Якщо підпункт без підменю
                if (subItem.DropDownItems.Count == 0)
                {
                    subItem.Click += MenuItem_Click; // Додавання обробника
                }
                else
                {
                    // Рекурсивно для підпунктів
                    AddClickEventToMenuItems(subItem);
                }
            }
        }

        // Обробник подій для меню
        private void MenuItem_Click(object sender, EventArgs e)
        {
            // Отримання пункту меню
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                // Відображення назви підпункту
                MessageBox.Show(clickedItem.Text, "Вибрано пункт меню");
            }
        }
    }
}
