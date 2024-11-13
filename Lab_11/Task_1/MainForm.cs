using Lab_11;
using System;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenFormG_Click(object sender, EventArgs e)
        {
            FormG formG = new FormG();
            formG.ShowDialog();
        }
    }
}
