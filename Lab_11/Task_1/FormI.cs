using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormI : Form
    {
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
    }
}
