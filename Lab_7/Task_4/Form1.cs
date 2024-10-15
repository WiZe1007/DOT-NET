using System;
using System.Windows.Forms;

namespace Task_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ≤н≥ц≥ал≥зац≥€ форми
        }

        private void Label_DoubleClick(object sender, EventArgs e)
        {
            // ќтримуЇмо м≥тку, на €к≥й було кл≥кнуто
            Label clickedLabel = sender as Label;

            // якщо м≥тка знайдена
            if (clickedLabel != null)
            {
                // ѕеремикаЇмо текст м≥тки
                ToggleLabelText(clickedLabel, "Label " + (clickedLabel.TabIndex + 1), "New Text " + (clickedLabel.TabIndex + 1));
            }
        }

        private void ToggleLabelText(Label label, string text1, string text2)
        {
            // ѕеремикаЇмо м≥ж двома текстами
            if (label.Text == text1)
            {
                label.Text = text2; // «м≥нюЇмо на новий текст
            }
            else
            {
                label.Text = text1; // ѕовертаЇмо старий текст
            }
        }
    }
}
