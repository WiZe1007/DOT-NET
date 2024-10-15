using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_13
{
    public partial class Form1 : Form
    {
        private int labelCount = 0; // Лічильник Label

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Обробка клавіш формою
            this.KeyDown += Form1_KeyDown; // Подія натискання
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Додати Label: Alt + Shift + A
            if (e.Alt && e.Shift && e.KeyCode == Keys.A)
            {
                AddLabel();
                e.Handled = true; // Припинити обробку
            }
            // Видалити Label: Alt + D
            else if (e.Alt && e.KeyCode == Keys.D)
            {
                RemoveLabel();
                e.Handled = true; // Припинити обробку
            }
        }

        private void AddLabel()
        {
            Label newLabel = new Label
            {
                Text = $"Label {++labelCount}", // Текст Label
                BackColor = Color.LightBlue, // Фон
                AutoSize = true // Автоматичний розмір
            };

            // Розрахунок позиції
            int x = (this.ClientSize.Width - newLabel.Width) / 2 + 30;
            int y = (this.ClientSize.Height - newLabel.Height) / 2 - 50 + (labelCount - 1) * 30;

            newLabel.Location = new Point(x, y); // Встановлення позиції
            this.Controls.Add(newLabel); // Додавання на форму
        }

        private void RemoveLabel()
        {
            if (labelCount > 0)
            {
                this.Controls.RemoveAt(this.Controls.Count - 1); // Видалення останнього Label
                labelCount--; // Зменшення лічильника
            }
            else
            {
                // Повідомлення про помилку
                MessageBox.Show("Немає Label для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
