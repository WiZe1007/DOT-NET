using System; // ������ ��������� �������� ���� ��� ������������ ������� �����.
using System.Windows.Forms; // ������ �������� ���� ��� ������ � ������� Windows.

namespace Task_5 // ���������� �������� ���� Task_5.
{
    public partial class Form1 : Form // ���������� ������� ����� Form1, �� ��������� �� ����� Form.
    {
        public Form1() // ����������� ����� Form1.
        {
            InitializeComponent(); // ������ ������ ��� ����������� ���������� �����.

            // ������������ ��������� ��� ������� CheckBox �� ���������� Label.
            checkBoxSports.Location = new System.Drawing.Point(330, 50); // ������������ ������� �������� ��� ������.
            labelSports.Location = new System.Drawing.Point(245, 50); // ������������ ������� ���� ��� ������.

            checkBoxTravel.Location = new System.Drawing.Point(289, 80); // ������������ ������� �������� ��� ��������.
            labelTravel.Location = new System.Drawing.Point(150, 80); // ������������ ������� ���� ��� ��������.

            checkBoxCrafting.Location = new System.Drawing.Point(291, 110); // ������������ ������� �������� ��� ������������.
            labelCrafting.Location = new System.Drawing.Point(95, 110); // ������������ ������� ���� ��� ������������.

            checkBoxPainting.Location = new System.Drawing.Point(332, 140); // ������������ ������� �������� ��� ���������.
            labelPainting.Location = new System.Drawing.Point(150, 140); // ������������ ������� ���� ��� ���������.
        }

        private void ButtonChoose_Click(object sender, EventArgs e) // �������� ��䳿 ���������� ������ "�������".
        {
            // ����� ��� ������� ���������� ������ "�������".
            string selectedInterests = "�� �������: "; // ����������� ����� ��� ����������� �������� ��������.

            if (checkBoxSports.Checked) // ��������, �� ������� �����.
                selectedInterests += "����� "; // ��������� "�����" �� ����� �������� ��������.
            if (checkBoxTravel.Checked) // ��������, �� ������� ��������.
                selectedInterests += "�������� "; // ��������� "��������" �� ����� �������� ��������.
            if (checkBoxCrafting.Checked) // ��������, �� ������� ������������.
                selectedInterests += "������������ "; // ��������� "������������" �� ����� �������� ��������.
            if (checkBoxPainting.Checked) // ��������, �� ������� ���������.
                selectedInterests += "��������� "; // ��������� "���������" �� ����� �������� ��������.

            MessageBox.Show(selectedInterests); // ³���������� �������� �������� � ��� �����������.
        }

        private void ButtonRefuse_Click(object sender, EventArgs e) // �������� ��䳿 ���������� ������ "³���������".
        {
            // ����� ��� ������� ���������� ������ "³���������".
            checkBoxSports.Checked = false; // ������ ������ � �������� ��� ������.
            checkBoxTravel.Checked = false; // ������ ������ � �������� ��� ��������.
            checkBoxCrafting.Checked = false; // ������ ������ � �������� ��� ������������.
            checkBoxPainting.Checked = false; // ������ ������ � �������� ��� ���������.

            MessageBox.Show("�� ���������� �� ������."); // ³���������� ����������� ��� ������ �� ������.
        }
    }
}
