using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormL : Form
    {
        public FormL()
        {
            InitializeComponent();

            Button buttonExample = new Button
            {
                Text = "Hello!",
                Font = new Font("Palatino Linotype", 12, FontStyle.Underline),
                ForeColor = Color.Teal,
                Location = new Point(20, 20),
                Size = new Size(150, 50)
            };

            this.Controls.Add(buttonExample);
        }
    }
}
