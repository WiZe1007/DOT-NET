using System;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������

            // ��������� ��� �� ComboBox � ListBox
            comboBox1.Items.AddRange(new string[] {
                "���",
                "����������",
                "ó��",
                "������",
                "�����"
            });
            listBox1.Items.AddRange(new string[] {
                "���",
                "����������",
                "ó��",
                "������",
                "�����"
            });
        }

        // ������� ������ � ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ��������� ��������� ����
            string selectedCity = comboBox1.SelectedItem.ToString();
            // ��������� �����������
            MessageBox.Show("�� ������� ����: " + selectedCity);
        }

        // ������� 2-�� ���� �� ListBox
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // �������� ������
            if (listBox1.SelectedItem != null)
            {
                // ��������� ��������� ����
                string selectedCity = listBox1.SelectedItem.ToString();
                // ��������� �����������
                MessageBox.Show("�� ������� ����: " + selectedCity);
            }
        }
    }
}
