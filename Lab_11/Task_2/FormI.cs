using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Lab_11_Task_2
{
    public partial class FormI : Form
    {
        public string CallingFormName { get; set; }
        public string CallingFormInfo { get; set; }
        public string ReturnedInfo { get; set; }

        public FormI()
        {
            InitializeComponent();

            Button buttonExample = new Button
            {
                Text = "Hello!",
                Font = new Font("Comic Sans MS", 10, FontStyle.Bold | FontStyle.Italic),
                ForeColor = Color.DarkCyan,
                Location = new Point(20, 20),
                Size = new Size(150, 50)
            };

            this.Controls.Add(buttonExample);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            labelInfo.Text = $"Called from {CallingFormName}: {CallingFormInfo}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ReturnedInfo = textBoxInfo.Text;
            base.OnFormClosing(e);
        }
    }
}
