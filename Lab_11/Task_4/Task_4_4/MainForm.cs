using System;
using System.Windows.Forms;

namespace Task_4_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // ³�������� ����� �������� �����
            InputForm inputForm = new InputForm();
            inputForm.Show();
        }
    }
}
