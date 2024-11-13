using System;
using System.Windows.Forms;

namespace Task_4_4
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(double result)
        {
            InitializeComponent();
            lblResult.Text = $"Результат: {result}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
