using System;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Створення контекстного меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Пункти меню
            ToolStripMenuItem swap1And2 = new ToolStripMenuItem("Swap Label 1 and Label 2");
            ToolStripMenuItem swap2And3 = new ToolStripMenuItem("Swap Label 2 and Label 3");
            ToolStripMenuItem swap1And3 = new ToolStripMenuItem("Swap Label 1 and Label 3");

            // Додавання пунктів до меню
            contextMenu.Items.Add(swap1And2);
            contextMenu.Items.Add(swap2And3);
            contextMenu.Items.Add(swap1And3);

            // Прив'язка меню до міток
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;

            // Обробка подій для пунктів меню
            swap1And2.Click += SwapLabels;
            swap2And3.Click += SwapLabels;
            swap1And3.Click += SwapLabels;
        }

        // Обробник подій для пунктів меню
        private void SwapLabels(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem; // Отримання об'єкта що викликав подію
            if (clickedItem != null)
            {
                // Визначення, які мітки обміняти
                if (clickedItem.Text == "Swap Label 1 and Label 2")
                {
                    SwapLabelText(this.label1, this.label2);
                }
                else if (clickedItem.Text == "Swap Label 2 and Label 3")
                {
                    SwapLabelText(this.label2, this.label3);
                }
                else if (clickedItem.Text == "Swap Label 1 and Label 3")
                {
                    SwapLabelText(this.label1, this.label3);
                }
            }
        }

        // Метод для обміну текстом між мітками
        private void SwapLabelText(System.Windows.Forms.Label labelA, System.Windows.Forms.Label labelB)
        {
            string temp = labelA.Text; // Зберігаємо текст мітки A
            labelA.Text = labelB.Text; // Обмін текстом
            labelB.Text = temp; // Завершення обміну
        }
    }
}
