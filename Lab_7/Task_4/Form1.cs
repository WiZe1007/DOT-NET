using System;
using System.Windows.Forms;

namespace Task_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� �����
        }

        private void Label_DoubleClick(object sender, EventArgs e)
        {
            // �������� ����, �� ��� ���� �������
            Label clickedLabel = sender as Label;

            // ���� ���� ��������
            if (clickedLabel != null)
            {
                // ���������� ����� ����
                ToggleLabelText(clickedLabel, "Label " + (clickedLabel.TabIndex + 1), "New Text " + (clickedLabel.TabIndex + 1));
            }
        }

        private void ToggleLabelText(Label label, string text1, string text2)
        {
            // ���������� �� ����� ��������
            if (label.Text == text1)
            {
                label.Text = text2; // ������� �� ����� �����
            }
            else
            {
                label.Text = text1; // ��������� ������ �����
            }
        }
    }
}
