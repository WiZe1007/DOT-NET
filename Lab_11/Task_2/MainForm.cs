using Lab_11_Task_2;
using System;
using System.Windows.Forms;

namespace Lab_11_Task_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.labelInfo.Text = "Welcome!";
        }

        private void buttonOpenFormG_Click(object sender, EventArgs e)
        {
            FormG formG = new FormG();

            // ³������� ����� �� ����� G
            formG.CallingFormName = this.Text;
            formG.CallingFormInfo = this.textBoxInfo.Text;

            formG.ShowDialog();

            // ��������� ����� �� ����� G
            this.labelInfo.Text = $"From {formG.Text}: {formG.ReturnedInfo}";
        }
    }
}
