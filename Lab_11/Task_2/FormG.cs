using Lab_11_Task_2;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Lab_11_Task_2
{
    public partial class FormG : Form
    {
        public string CallingFormName { get; set; }
        public string CallingFormInfo { get; set; }
        public string ReturnedInfo { get; set; }

        public FormG()
        {
            InitializeComponent();

            // Налаштування шрифтів і кольорів кнопок
            buttonOpenFormH.Font = new Font("Arial", 10, FontStyle.Bold);
            buttonOpenFormH.ForeColor = Color.Red;

            buttonOpenFormI.Font = new Font("Times New Roman", 12, FontStyle.Italic);
            buttonOpenFormI.ForeColor = Color.Blue;

            buttonOpenFormJ.Font = new Font("Verdana", 10, FontStyle.Underline);
            buttonOpenFormJ.ForeColor = Color.Green;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Відображення імені та інформації форми виклику
            labelInfo.Text = $"Called from {CallingFormName}: {CallingFormInfo}";
        }

        private void buttonOpenFormH_Click(object sender, EventArgs e)
        {
            FormH formH = new FormH();

            // Передача даних до FormH
            formH.CallingFormName = this.Text;
            formH.CallingFormInfo = this.textBoxInfo.Text;

            formH.ShowDialog();

            // Прийняття даних від FormH
            this.labelInfo.Text = $"From {formH.Text}: {formH.ReturnedInfo}";
        }

        private void buttonOpenFormI_Click(object sender, EventArgs e)
        {
            FormI formI = new FormI();

            // Передача даних до FormI
            formI.CallingFormName = this.Text;
            formI.CallingFormInfo = this.textBoxInfo.Text;

            formI.ShowDialog();

            // Прийняття даних від FormI
            this.labelInfo.Text = $"From {formI.Text}: {formI.ReturnedInfo}";
        }

        private void buttonOpenFormJ_Click(object sender, EventArgs e)
        {
            FormJ formJ = new FormJ();

            // Передача даних до FormJ
            formJ.CallingFormName = this.Text;
            formJ.CallingFormInfo = this.textBoxInfo.Text;

            formJ.ShowDialog();

            // Прийняття даних від FormJ
            this.labelInfo.Text = $"From {formJ.Text}: {formJ.ReturnedInfo}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Налаштування ReturnedInfo для надсилання назад до форми виклику
            ReturnedInfo = textBoxInfo.Text;
            base.OnFormClosing(e);
        }
    }
}
