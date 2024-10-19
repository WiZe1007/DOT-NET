using System;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Додавання обробника подій для меню
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                AddClickEventToMenuItems(menuItem);
            }
        }

        // Рекурсивний метод для обробки підпунктів меню
        private void AddClickEventToMenuItems(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
            {
                // Додавання обробника для підпункту
                subItem.Click += (s, e) => ShowMessage(subItem.Text);

                // Рекурсивно обробляємо підпункти
                if (subItem.DropDownItems.Count > 0)
                {
                    AddClickEventToMenuItems(subItem);
                }
            }
        }

        private void ShowMessage(string itemName)
        {
            // Виводення назви підпункту у вікні повідомлення
            MessageBox.Show(itemName, "Вибрано пункт меню");
        }
    }
}
