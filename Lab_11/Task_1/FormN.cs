using System.Drawing;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class FormN : Form
    {
        public FormN()
        {
            InitializeComponent();

            Button buttonExample = new Button
            {
                Text = "Hello!",
                Font = new Font("Century Gothic", 10, FontStyle.Strikeout),
                ForeColor = Color.DarkMagenta,
                Location = new Point(20, 20),
                Size = new Size(150, 50)
            };

            this.Controls.Add(buttonExample);
        }
    }
}
