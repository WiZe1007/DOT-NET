using System; // ��������� ����� �������� ���� ��� ������ � ���������� ���������
using System.Windows.Forms; // ��������� ������ ���� ��� ������ � ���������� ����� Windows

namespace Task9 // ��������� ������ ���� ��� ��������
{
    public partial class Form1 : Form // ��������� ���� Form1, ���� � ��������� ������ � ������������� �� ����� Form
{
    public Form1() // ����������� ����� Form1
    {
        InitializeComponent(); // ���������� ���������� ����� (����������� ������������ ���)
                               // �������� ������������ ��� ��䳿 ��� ������ ����� ������ ���
        AddButtonHandlers(); // ��������� ����� ��� ����'���� ���� �� ������
    }

    private void AddButtonHandlers() // ����� ��� ��������� ��������� ���� �� ������
    {
        // ����'����� ��䳿 �� ������
        toolStripButton1.Click += Tool1_Click; // ����'����� �������� Tool1_Click �� ��䳿 ���������� ������ toolStripButton1
        toolStripButton2.Click += Tool2_Click; // ����'����� �������� Tool2_Click �� ��䳿 ���������� ������ toolStripButton2
        toolStripButton3.Click += Tool3_Click; // ����'����� �������� Tool3_Click �� ��䳿 ���������� ������ toolStripButton3
        toolStripButton4.Click += Tool4_Click; // ����'����� �������� Tool4_Click �� ��䳿 ���������� ������ toolStripButton4
    }

    // ��������� ���� ��� ������
    private void Tool1_Click(object sender, EventArgs e) // �������� ��䳿 ��� ������ toolStripButton1
    {
        MessageBox.Show("��������� ������ Tool1"); // �������� ����������� ��� ��������� ������
    }

    private void Tool2_Click(object sender, EventArgs e) // �������� ��䳿 ��� ������ toolStripButton2
    {
        MessageBox.Show("��������� ������ Tool2"); // �������� ����������� ��� ��������� ������
    }

    private void Tool3_Click(object sender, EventArgs e) // �������� ��䳿 ��� ������ toolStripButton3
    {
        MessageBox.Show("��������� ������ Tool3"); // �������� ����������� ��� ��������� ������
    }

    private void Tool4_Click(object sender, EventArgs e) // �������� ��䳿 ��� ������ toolStripButton4
    {
        MessageBox.Show("��������� ������ Tool4"); // �������� ����������� ��� ��������� ������
    }
}

}