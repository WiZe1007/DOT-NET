using Lab_11_Task_2;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Lab_11_Task_2
{
    public partial class FormJ : Form
    {
        public string CallingFormName { get; set; }
        public string CallingFormInfo { get; set; }
        public string ReturnedInfo { get; set; }

        public FormJ()
        {
            InitializeComponent();

            buttonOpenFormK.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonOpenFormK.ForeColor = Color.DarkBlue;

            buttonOpenFormL.Font = new Font("Georgia", 10, FontStyle.Italic);
            buttonOpenFormL.ForeColor = Color.Crimson;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            labelInfo.Text = $"Called from {CallingFormName}: {CallingFormInfo}";
        }

        private void buttonOpenFormK_Click(object sender, EventArgs e)
        {
            FormK formK = new FormK();

            // Передача даних до форми K
            formK.CallingFormName = this.Text;
            formK.CallingFormInfo = this.textBoxInfo.Text;

            formK.ShowDialog();

            // Прийняття даних від форми K
            this.labelInfo.Text = $"From {formK.Text}: {formK.ReturnedInfo}";
        }

        private void buttonOpenFormL_Click(object sender, EventArgs e)
        {
            FormL formL = new FormL();

            // Передача даних до форми L
            formL.CallingFormName = this.Text;
            formL.CallingFormInfo = this.textBoxInfo.Text;

            formL.ShowDialog();

            // Прийняття даних від форми L
            this.labelInfo.Text = $"From {formL.Text}: {formL.ReturnedInfo}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ReturnedInfo = textBoxInfo.Text;
            base.OnFormClosing(e);
        }
    }
}
