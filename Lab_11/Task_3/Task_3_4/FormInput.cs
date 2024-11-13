using System;
using System.Windows.Forms;

namespace Task_3_4
{
    public partial class FormInput : Form
    {
        public double Hypotenuse { get; private set; }

        public FormInput()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double hypotenuse;
            if (!double.TryParse(textBoxHypotenuse.Text, out hypotenuse) || hypotenuse <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректне додатне число для гіпотенузи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hypotenuse = hypotenuse;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
