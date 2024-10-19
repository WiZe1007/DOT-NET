using System;
using System.Drawing; 
using System.Windows.Forms; 

namespace Task_003 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent(); 
        }

        private void buttonSend_Click(object sender, EventArgs e) // Обробка кліку на "Відіслати"
        {
            // Масиви для чекбоксів та відповідних міток
            var checkBoxes = new CheckBox[] { checkBoxSports, checkBoxTravel, checkBoxCrafting, checkBoxPainting };
            var labels = new Label[] { labelSports, labelTravel, labelCrafting, labelPainting };
            var selectedItems = ""; // Змінна для зберігання вибраних елементів

            // Зміна шрифтів для вибраних елементів
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    labels[i].Font = new Font(labels[i].Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    selectedItems += labels[i].Text + "\n"; // Додавання вибраного елементу до списку
                }
            }

            // Відображення вибраних елементів у MessageBox
            if (string.IsNullOrEmpty(selectedItems))
            {
                MessageBox.Show("Не вибрано жодного елемента.", "Вибір", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вибрані елементи:\n" + selectedItems, "Вибір", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) // Обробка кліку на "Скинути"
        {
            // Масиви для скидання шрифтів та чекбоксів
            var labels = new Label[] { labelSports, labelTravel, labelCrafting, labelPainting };
            var checkBoxes = new CheckBox[] { checkBoxSports, checkBoxTravel, checkBoxCrafting, checkBoxPainting };

            // Скидання шрифтів до стандартного
            foreach (var label in labels)
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }

            // Скидання чекбоксів
            checkBoxSports.Checked = true; // "Спорт"
            checkBoxTravel.Checked = false; // "Мандрівки"
            checkBoxCrafting.Checked = true; // "Майстрування"
            checkBoxPainting.Checked = false; // "Малювання"
        }
    }
}
