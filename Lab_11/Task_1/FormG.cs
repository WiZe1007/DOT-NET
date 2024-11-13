using Lab_11;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormG : Form
    {
        public FormG()
        {
            InitializeComponent();

            // Customize button fonts and colors
            buttonOpenFormH.Font = new Font("Arial", 10, FontStyle.Bold);
            buttonOpenFormH.ForeColor = Color.Red;

            buttonOpenFormI.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            buttonOpenFormI.ForeColor = Color.Blue;

            buttonOpenFormJ.Font = new Font("Verdana", 10, FontStyle.Underline);
            buttonOpenFormJ.ForeColor = Color.Green;
        }

        private void buttonOpenFormH_Click(object sender, EventArgs e)
        {
            FormH formH = new FormH();
            formH.ShowDialog();
        }

        private void buttonOpenFormI_Click(object sender, EventArgs e)
        {
            FormI formI = new FormI();
            formI.ShowDialog();
        }

        private void buttonOpenFormJ_Click(object sender, EventArgs e)
        {
            FormJ formJ = new FormJ();
            formJ.ShowDialog();
        }
    }
}
