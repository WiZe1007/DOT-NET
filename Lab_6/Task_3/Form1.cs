using System; // ϳ��������� �������� ���� ��� ��������� �����, ����� �� DateTime
using System.Windows.Forms; // ϳ��������� �������� ���� ��� ����� Windows Forms

namespace Task_3 // ���������� �������� ���� ��� ���������� ����
{
    public partial class Form1 : Form // ���������� ����� Form1, ���� ��������� ���� Form
    {
        public Form1() // ����������� ����� Form1
        {
            InitializeComponent(); // ������ ������ ����������� ���������� �����
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // �����-�������� ��䳿 ���������� ������ "³��������"
        {
            // ����� ��� ������� ���������� ������ "³��������"
            MessageBox.Show("��� ����������!"); // ³���������� �����������, �� ��� ����������
        }

        private void ButtonReset_Click(object sender, EventArgs e) // �����-�������� ��䳿 ���������� ������ "�������"
        {
            // ����� ��� ������� ���������� ������ "�������"
            textBoxName.Clear(); // �������� ���������� ���� ��� ����
            textBoxPhone.Clear(); // �������� ���������� ���� ��� ��������
            textBoxEmail.Clear(); // �������� ���������� ���� ��� ���������� �����
            dateTimePickerDOB.Value = DateTime.Now; // �������� �������� ������ ���� �� ���������� ����
        }
    }
}
