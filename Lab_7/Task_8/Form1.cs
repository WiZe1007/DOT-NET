using System;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
        }

        // �������� ���� ��� ����
        private void Label_MouseHandler(object sender, MouseEventArgs e)
        {
            // �������� �� ���� ��� ����
            if (sender is Label label && e.Button == MouseButtons.Left)
            {
                // ���� ������ ����
                switch (label.Text)
                {
                    case "����� 1":
                        label.Text = "������� ����� 1";
                        break;
                    case "����� 2":
                        label.Text = "������� ����� 2";
                        break;
                    case "����� 3":
                        label.Text = "������� ����� 3";
                        break;
                    // ���������� �� ����������� ������
                    case "������� ����� 1":
                        label.Text = "����� 1";
                        break;
                    case "������� ����� 2":
                        label.Text = "����� 2";
                        break;
                    case "������� ����� 3":
                        label.Text = "����� 3";
                        break;
                }
            }
        }
    }
}
