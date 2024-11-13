using System;
using System.Windows.Forms;
using Task_3_2;

namespace Task_3_2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInputData_Click(object sender, EventArgs e)
        {
            FormInput inputForm = new FormInput();
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                double hypotenuse = inputForm.Hypotenuse;
                CalculateAndDisplayResults(hypotenuse);
            }
        }

        private void CalculateAndDisplayResults(double hypotenuse)
        {
            double leg = hypotenuse / Math.Sqrt(2);
            double perimeter = hypotenuse + 2 * leg;
            double area = (leg * leg) / 2;

            labelPerimeter.Text = $"Периметр: {perimeter:F2}";
            labelArea.Text = $"Площа: {area:F2}";
        }
    }
}
