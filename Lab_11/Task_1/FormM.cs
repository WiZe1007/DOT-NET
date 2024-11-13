using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormM : Form
    {
        public FormM()
        {
            InitializeComponent();

            Button buttonExample = new Button
            {
                Text = "Hello!",
                Font = new Font("Arial Narrow", 10, FontStyle.Italic),
                ForeColor = Color.Maroon,
                Location = new Point(20, 20),
                Size = new Size(150, 50)
            };

            this.Controls.Add(buttonExample);
        }
    }
}
