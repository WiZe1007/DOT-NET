using System;
using System.Windows.Forms;
using Task_3_3;

namespace Task_3_3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double hypotenuse;
            if (!double.TryParse(textBoxHypotenuse.Text, out hypotenuse) || hypotenuse <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректне додатне число для гіпотенузи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double leg = hypotenuse / Math.Sqrt(2);
            double perimeter = hypotenuse + 2 * leg;
            double area = (leg * leg) / 2;

            FormResult resultForm = new FormResult(perimeter, area);
            resultForm.Show();
        }
    }
}
