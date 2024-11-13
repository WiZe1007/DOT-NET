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

        // Обробник події натискання кнопки "Розрахувати"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double hypotenuse;

            // Спроба перетворити текст з TextBox у число
            if (!double.TryParse(textBoxHypotenuse.Text, out hypotenuse) || hypotenuse <= 0)
            {
                // Виведення повідомлення про помилку при некоректному введенні
                MessageBox.Show("Будь ласка, введіть коректне додатне число для гіпотенузи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Розрахунок катета
            double leg = hypotenuse / Math.Sqrt(2);

            // Розрахунок периметра
            double perimeter = hypotenuse + 2 * leg;

            // Розрахунок площі
            double area = (leg * leg) / 2;

            // Відображення результатів
            labelPerimeter.Text = $"Периметр: {perimeter:F2}";
            labelArea.Text = $"Площа: {area:F2}";
        }
    }
}
