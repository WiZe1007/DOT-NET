using System;
using System.Windows.Forms;

namespace Task_4_3
{
    public partial class ResultsForm : Form
    {
        public ResultsForm(double result)
        {
            InitializeComponent();
            lblResult.Text = $"Результат: {result}";
        }
    }
}
