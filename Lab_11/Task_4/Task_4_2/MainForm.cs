using System;
using System.Windows.Forms;

namespace Task_4_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenInputForm_Click(object sender, EventArgs e)
        {
            // Створюємо екземпляр форми введення
            InputForm inputForm = new InputForm();

            // Відображаємо форму введення як модальну
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                // Отримуємо введені значення
                int x = inputForm.X;
                double y = inputForm.Y;
                double z = inputForm.Z;

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
