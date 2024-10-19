using System;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
            AddButtonHandlers();    // ��������� ��������� ���� ��� ������
        }

        private void AddButtonHandlers()
        {
            // ����'���� ��������� �� ������
            toolStripButton1.Click += Button_Click;
            toolStripButton2.Click += Button_Click;
            toolStripButton3.Click += Button_Click;
            toolStripButton4.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton button) // �������� ���� sender
            {
                MessageBox.Show($"��������� ������ {button.Text}"); // ��������� �����������
            }
        }
    }
}
