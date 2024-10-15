using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_13
{
    public partial class Form1 : Form
    {
        private int labelCount = 0; // ˳������� Label

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // ������� ����� ������
            this.KeyDown += Form1_KeyDown; // ���� ����������
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ������ Label: Alt + Shift + A
            if (e.Alt && e.Shift && e.KeyCode == Keys.A)
            {
                AddLabel();
                e.Handled = true; // ��������� �������
            }
            // �������� Label: Alt + D
            else if (e.Alt && e.KeyCode == Keys.D)
            {
                RemoveLabel();
                e.Handled = true; // ��������� �������
            }
        }

        private void AddLabel()
        {
            Label newLabel = new Label
            {
                Text = $"Label {++labelCount}", // ����� Label
                BackColor = Color.LightBlue, // ���
                AutoSize = true // ������������ �����
            };

            // ���������� �������
            int x = (this.ClientSize.Width - newLabel.Width) / 2 + 30;
            int y = (this.ClientSize.Height - newLabel.Height) / 2 - 50 + (labelCount - 1) * 30;

            newLabel.Location = new Point(x, y); // ������������ �������
            this.Controls.Add(newLabel); // ��������� �� �����
        }

        private void RemoveLabel()
        {
            if (labelCount > 0)
            {
                this.Controls.RemoveAt(this.Controls.Count - 1); // ��������� ���������� Label
                labelCount--; // ��������� ���������
            }
            else
            {
                // ����������� ��� �������
                MessageBox.Show("���� Label ��� ���������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
