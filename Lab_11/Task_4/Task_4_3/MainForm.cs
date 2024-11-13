using System;
using System.Windows.Forms;

namespace Task_4_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int x;
            double y, z;

            // �������� ���������� �������� x
            if (!int.TryParse(txtX.Text, out x) || x <= 0)
            {
                MessageBox.Show("������ �������� ������� ���� ����� ��� x.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // �������� ���������� �������� y
            if (!double.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("������ �������� ����� ��� y.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // �������� ���������� �������� z
            if (!double.TryParse(txtZ.Text, out z))
            {
                MessageBox.Show("������ �������� ����� ��� z.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double result = CalculateExpression(x, y, z);

                // ³�������� ����� ���������� � �������� ���������
                ResultsForm resultsForm = new ResultsForm(result);
                resultsForm.Show();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "������� ����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� ������� �� ��� ����������: " + ex.Message, "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateExpression(int x, double y, double z)
        {
            double sum = 0.0;

            for (int i = 1; i <= x; i++)
            {
                double product = 1.0;

                for (int j = 1; j <= i; j++)
                {
                    double denominator = i + j + z;
                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("ĳ����� �� ���� ��� i + j + z.");
                    }

                    product *= (x * y * z) / denominator;
                }

                sum += product;
            }

            return sum;
        }
    }
}
