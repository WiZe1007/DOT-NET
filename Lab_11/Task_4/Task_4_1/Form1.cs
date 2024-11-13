using System;
using System.Windows.Forms;

namespace Lab_11_Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int x;
            double y, z;

            // Перевірка коректності введення x
            if (!int.TryParse(txtX.Text, out x) || x <= 0)
            {
                MessageBox.Show("Введіть коректне додатне ціле число для x.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка коректності введення y
            if (!double.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("Введіть коректне число для y.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка коректності введення z
            if (!double.TryParse(txtZ.Text, out z))
            {
                MessageBox.Show("Введіть коректне число для z.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double result = CalculateExpression(x, y, z);
                lblResult.Text = $"Результат: {result}";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Помилка обчислення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка під час обчислення: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        throw new DivideByZeroException("Ділення на нуль при i + j + z.");
                    }

                    product *= (x * y * z) / denominator;
                }

                sum += product;
            }

            return sum;
        }
    }
}
