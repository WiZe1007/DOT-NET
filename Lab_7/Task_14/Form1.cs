using System;
using System.Windows.Forms;

namespace Task_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Запит про завантаження
            DialogResult result = MessageBox.Show("Чи потрібно завантажити форму?", "Завантаження форми", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close(); // Закриття
            }
            else
            {
                // Налаштування якщо вибрано "Так"
                this.StartPosition = FormStartPosition.Manual;
                this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height);
                this.Location = new System.Drawing.Point(0, 0);
            }
        }
    }
}
