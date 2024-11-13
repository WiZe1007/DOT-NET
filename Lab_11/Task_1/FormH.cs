using Lab_11;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormH : Form
    {
        public FormH()
        {
            InitializeComponent();

            buttonOpenFormM.Font = new Font("Courier New", 12, FontStyle.Bold);
            buttonOpenFormM.ForeColor = Color.Purple;

            buttonOpenFormN.Font = new Font("Calibri", 11, FontStyle.Strikeout);
            buttonOpenFormN.ForeColor = Color.DarkOrange;
        }

        private void buttonOpenFormM_Click(object sender, EventArgs e)
        {
            FormM formM = new FormM();
            formM.ShowDialog();
        }

        private void buttonOpenFormN_Click(object sender, EventArgs e)
        {
            FormN formN = new FormN();
            formN.ShowDialog();
        }
    }
}
