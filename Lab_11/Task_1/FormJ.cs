using Lab_11;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormJ : Form
    {
        public FormJ()
        {
            InitializeComponent();

            buttonOpenFormK.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonOpenFormK.ForeColor = Color.DarkBlue;

            buttonOpenFormL.Font = new Font("Georgia", 10, FontStyle.Italic);
            buttonOpenFormL.ForeColor = Color.Crimson;
        }

        private void buttonOpenFormK_Click(object sender, EventArgs e)
        {
            FormK formK = new FormK();
            formK.ShowDialog();
        }

        private void buttonOpenFormL_Click(object sender, EventArgs e)
        {
            FormL formL = new FormL();
            formL.ShowDialog();
        }
    }
}
