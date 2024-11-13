using System;
using System.Windows.Forms;

namespace Task_4_2
{
    public partial class InputForm : Form
    {
        public int X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int x;
            double y, z;

            // Перевірка коректності введення x
            if (!int.TryParse(txtX.Text, out x) || x <= 0)
            {
                MessageBox.Show("Введіть коректне додатне ціле число для x.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка коректності введення y
            if (!double.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("Введіть коректне число для y.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка коректності введення z
            if (!double.TryParse(txtZ.Text, out z))
            {
                MessageBox.Show("Введіть коректне число для z.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Збереження введених значень
            X = x;
            Y = y;
            Z = z;

            // Закриваємо форму з результатом DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
