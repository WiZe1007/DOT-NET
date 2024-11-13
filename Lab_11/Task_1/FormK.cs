using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormK : Form
    {
        public FormK()
        {
            InitializeComponent();

            Button buttonExample = new Button
            {
                Text = "Hello!",
                Font = new Font("Tahoma", 11, FontStyle.Bold),
                ForeColor = Color.Navy,
                Location = new Point(20, 20),
                Size = new Size(150, 50)
            };

            this.Controls.Add(buttonExample);
        }
    }
}
