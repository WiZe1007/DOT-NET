using System;
using System.Windows.Forms;

namespace Lab_11_Task_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // �������� ��䳿 ���������� ������ "�����������"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double hypotenuse;

            // ������ ����������� ����� � TextBox � �����
            if (!double.TryParse(textBoxHypotenuse.Text, out hypotenuse) || hypotenuse <= 0)
            {
                // ��������� ����������� ��� ������� ��� ������������ �������
                MessageBox.Show("���� �����, ������ �������� ������� ����� ��� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ���������� ������
            double leg = hypotenuse / Math.Sqrt(2);

            // ���������� ���������
            double perimeter = hypotenuse + 2 * leg;

            // ���������� �����
            double area = (leg * leg) / 2;

            // ³���������� ����������
            labelPerimeter.Text = $"��������: {perimeter:F2}";
            labelArea.Text = $"�����: {area:F2}";
        }
    }
}
