using System.Windows.Forms;

namespace Task_3_3
{
    public partial class FormResult : Form
    {
        public FormResult(double perimeter, double area)
        {
            InitializeComponent();
            labelPerimeter.Text = $"Периметр: {perimeter:F2}";
            labelArea.Text = $"Площа: {area:F2}";
        }
    }
}
