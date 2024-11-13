using Lab_11_Task_2;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Lab_11_Task_2
{
    public partial class FormH : Form
    {
        public string CallingFormName { get; set; }
        public string CallingFormInfo { get; set; }
        public string ReturnedInfo { get; set; }

        public FormH()
        {
            InitializeComponent();

            buttonOpenFormM.Font = new Font("Courier New", 12, FontStyle.Bold);
            buttonOpenFormM.ForeColor = Color.Purple;

            buttonOpenFormN.Font = new Font("Calibri", 11, FontStyle.Strikeout);
            buttonOpenFormN.ForeColor = Color.DarkOrange;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            labelInfo.Text = $"Called from {CallingFormName}: {CallingFormInfo}";
        }

        private void buttonOpenFormM_Click(object sender, EventArgs e)
        {
            FormM formM = new FormM();

            // Передача даних до форми M
            formM.CallingFormName = this.Text;
            formM.CallingFormInfo = this.textBoxInfo.Text;

            formM.ShowDialog();

            // Прийняття даних від форми M
            this.labelInfo.Text = $"From {formM.Text}: {formM.ReturnedInfo}";
        }

        private void buttonOpenFormN_Click(object sender, EventArgs e)
        {
            FormN formN = new FormN();

            // Передача даних до форми N
            formN.CallingFormName = this.Text;
            formN.CallingFormInfo = this.textBoxInfo.Text;

            formN.ShowDialog();

            // Прийняття даних від форми N
            this.labelInfo.Text = $"From {formN.Text}: {formN.ReturnedInfo}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ReturnedInfo = textBoxInfo.Text;
            base.OnFormClosing(e);
        }
    }
}
