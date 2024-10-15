using System;
using System.Windows.Forms;

namespace Task_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // �����������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ����� ��� ������������
            DialogResult result = MessageBox.Show("�� ������� ����������� �����?", "������������ �����", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                this.Close(); // ��������
            }
            else
            {
                // ������������ ���� ������� "���"
                this.StartPosition = FormStartPosition.Manual;
                this.Size = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width / 2, Screen.PrimaryScreen.WorkingArea.Height);
                this.Location = new System.Drawing.Point(0, 0);
            }
        }
    }
}
