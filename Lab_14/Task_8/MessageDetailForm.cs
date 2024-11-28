using System;
using System.Windows.Forms;

namespace Lab__12
{
    public partial class MessageDetailForm : Form
    {
        public MessageDetailForm(string from, string theme, string text, DateTime date)
        {
            InitializeComponent();
            fromLabel.Text = $"From: {from}";
            themeLabel.Text = $"Theme: {theme}";
            textTextBox.Text = text;
            dateLabel.Text = $"Date: {date.ToString("dd.MM.yyyy HH:mm")}";
        }
    }
}
