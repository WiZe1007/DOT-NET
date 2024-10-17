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
                // ���� ������ ���� �� ��������� switch expression
                label.Text = label.Text switch
                {
                    "����� 1" => "������� ����� 1",
                    "����� 2" => "������� ����� 2",
                    "����� 3" => "������� ����� 3",
                    "������� ����� 1" => "����� 1",
                    "������� ����� 2" => "����� 2",
                    "������� ����� 3" => "����� 3",
                    _ => label.Text // ���������� ��������� ������, ���� ���� ����
                };
            }
        }
    }
}
