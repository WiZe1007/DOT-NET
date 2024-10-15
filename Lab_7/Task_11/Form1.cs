using System;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
            CenterTextBox(); // �������� �������� ����
        }

        private void CenterTextBox()
        {
            // �������� textBox1 � ����
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            textBox1.Top = (this.ClientSize.Height - textBox1.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // �������� �������� ���� ��� ��� ������
            CenterTextBox();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ���������� ���� ���� �����
            if (char.IsDigit(e.KeyChar))
            {
                int digit = int.Parse(e.KeyChar.ToString());
                if (digit % 2 != 0) e.Handled = true; // ������� ������
            }
            else if (!char.IsControl(e.KeyChar)) e.Handled = true; // ������� ���� �������
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // �������� ���������� ���� ��� ��������� Esc
            if (e.KeyCode == Keys.Escape) textBox1.Clear();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // �������� �������� ������
            Console.WriteLine($"Key released: {e.KeyCode}");
        }
    }
}
