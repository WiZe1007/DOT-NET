using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів

            // Створення контекстного меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Створення пунктів меню
            ToolStripMenuItem swap1And2 = new ToolStripMenuItem("Swap Label 1 and Label 2");
            ToolStripMenuItem swap2And3 = new ToolStripMenuItem("Swap Label 2 and Label 3");
            ToolStripMenuItem swap1And3 = new ToolStripMenuItem("Swap Label 1 and Label 3");

            // Додавання пунктів меню до контекстного меню
            contextMenu.Items.Add(swap1And2);
            contextMenu.Items.Add(swap2And3);
            contextMenu.Items.Add(swap1And3);

            // Прив'язка контекстного меню до міток
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;

            // Додавання обробників подій для пунктів меню
            swap1And2.Click += (s, e) => SwapLabelText(label1, label2);
            swap2And3.Click += (s, e) => SwapLabelText(label2, label3);
            swap1And3.Click += (s, e) => SwapLabelText(label1, label3);
        }

        // Метод для обміну текстом між мітками
        private void SwapLabelText(System.Windows.Forms.Label labelA, System.Windows.Forms.Label labelB)
        {
            string temp = labelA.Text; // Збереження тексту 1 мітки
            labelA.Text = labelB.Text; // Присвоєння тексту з 2 мітки 1
            labelB.Text = temp; // Встановлення тексту 1 мітки 2
        }
    }
}
