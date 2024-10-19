using System;
using System.Drawing; // ��� ������ � ��������
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
        }

        // �������� ��䳿 "³������"
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // ������, ���������, ����������� �����
            FontStyle fontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
            textBoxName.Font = new Font(textBoxName.Font, fontStyle); // ����� ����
            textBoxPhone.Font = new Font(textBoxPhone.Font, fontStyle); // ����� ��� ��������
            textBoxEmail.Font = new Font(textBoxEmail.Font, fontStyle); // ����� ��� ���������� �����

            // ����������� ��� ������ �����������
            MessageBox.Show("��� ����������!", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // �������� ��䳿 "�������"
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            // �������� ��������� ����
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();

            // �������� ���� �� �������
            dateTimePickerDOB.Value = DateTime.Now;

            // ³��������� ������������ ������
            textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular); // ����� ��� ����
            textBoxPhone.Font = new Font(textBoxPhone.Font, FontStyle.Regular); // ����� ��� ��������
            textBoxEmail.Font = new Font(textBoxEmail.Font, FontStyle.Regular); // ����� ��� ���������� �����
        }
    }
}
