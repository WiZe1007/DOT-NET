using System;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
        }

        // �������� ���������� ��� 1 ������
        private void Label_MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������
            {
                label1.Text = "������� ����� 1"; // ���� ������
            }
        }

        // �������� ���������� ��� 1 ������
        private void Label_MouseUp1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������
            {
                label1.Text = "����� 1"; // ���������� ������
            }
        }

        // �������� ���������� ��� 2 ������
        private void Label_MouseDown2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������
            {
                label2.Text = "������� ����� 2"; // ���� ������
            }
        }

        // �������� ���������� ��� 2 ������
        private void Label_MouseUp2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������
            {
                label2.Text = "����� 2"; // ���������� ������
            }
        }

        // �������� ���������� ��� 3 ������
        private void Label_MouseDown3(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������
            {
                label3.Text = "������� ����� 3"; // ���� ������
            }
        }

        // �������� ���������� ��� 3 ������
        private void Label_MouseUp3(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ���� ��� ������
            {
                label3.Text = "����� 3"; // ���������� ������
            }
        }
    }
}
