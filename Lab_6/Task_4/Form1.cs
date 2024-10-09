using System; // ϳ��������� �������� ���� ��� ������ � �������� ������� .NET
using System.Windows.Forms; // ϳ��������� �������� ���� ��� ������ � ������� Windows Forms

namespace Task_4 // ���������� �������� ���� ��� ��������
{
    public partial class Form1 : Form // ���������� ����� Form1, ���� � �������� �����
    {
        public Form1() // ����������� �����
        {
            InitializeComponent(); // ����������� ���������� �����
            // ������������ ������ �� ����������� ��� ����������
            radioButtonKharkiv.Checked = true; // ���� ������� �� ���� �� �����������
            radioButtonTrain.Checked = true; // ���� ������ �� ���������� �� �����������
        }

        private void buttonSelect_Click(object sender, EventArgs e) // �������� ��䳿 ���������� ������ "�������"
        {
            string selectedCity = ""; // ����� ��� ���������� ��������� ����
            string selectedTransport = ""; // ����� ��� ���������� ��������� ����������

            // ��������, ��� ���� ���� ������� �� ��������� ����������
            if (radioButtonKharkiv.Checked)
                selectedCity = radioButtonKharkiv.Text; // ���� ������� �����
            else if (radioButtonKyiv.Checked)
                selectedCity = radioButtonKyiv.Text; // ���� ������� ���
            else if (radioButtonOdesa.Checked)
                selectedCity = radioButtonOdesa.Text; // ���� ������� �����
            else if (radioButtonZaporizhzhia.Checked)
                selectedCity = radioButtonZaporizhzhia.Text; // ���� ������� ��������

            // ��������, ���� ��������� ��� �������� �� ��������� ����������
            if (radioButtonBus.Checked)
                selectedTransport = radioButtonBus.Text; // ���� ������� �������
            else if (radioButtonTrain.Checked)
                selectedTransport = radioButtonTrain.Text; // ���� ������� �����
            else if (radioButtonPlane.Checked)
                selectedTransport = radioButtonPlane.Text; // ���� ������� ����

            // ��������� ����������� � ��������� ����� � �����������
            MessageBox.Show($"�� ������� ����: {selectedCity} �� ���������: {selectedTransport}", "����");
        }

        private void buttonCancel_Click(object sender, EventArgs e) // �������� ��䳿 ���������� ������ "���������"
        {
            this.Close(); // �������� �����
        }
    }
}
