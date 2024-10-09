using System; // ϳ�������� ������ ���� System, ���� ������ ����� ���� ����� �� ���������������.
using System.Windows.Forms; // ϳ�������� ������ ���� ��� ������ � Windows Forms.

namespace Task_2 // ���������� �������� ���� Task_2.
{
    public partial class Form1 : Form // ���������� ���������� ����� Form1, ���� ������ ���� Form.
    {
        public Form1() // ����������� ����� Form1.
        {
            InitializeComponent(); // ��������� ����� ��� ����������� ���������� �����.
            LoadCities(); // ��������� ����� ��� ������������ ��� �� ������.
        }

        private void LoadCities() // ����� ��� ������������ ��� � ����������� ������ � ������.
        {
            string[] cities = { "���", "����������", "ó��", "������", "�����" }; // ����� ��� ������.

            // ��������� ��� �� ComboBox
            comboBoxCities.Items.AddRange(cities); // ������ ����� ��� �� ������������ ������.

            // ��������� ��� �� ListBox
            listBoxCities.Items.AddRange(cities); // ������ ����� ��� �� ������.
        }
    }
}
