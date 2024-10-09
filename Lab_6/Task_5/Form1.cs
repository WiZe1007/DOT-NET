using System; // Імпорт основного простору імен для використання базових класів.
using System.Windows.Forms; // Імпорт простору імен для роботи з формами Windows.

namespace Task_5 // Визначення простору імен Task_5.
{
    public partial class Form1 : Form // Оголошення частини класу Form1, що успадковує від класу Form.
    {
        public Form1() // Конструктор класу Form1.
        {
            InitializeComponent(); // Виклик методу для ініціалізації компонентів форми.

            // Встановлення координат для кожного CheckBox та відповідного Label.
            checkBoxSports.Location = new System.Drawing.Point(330, 50); // Встановлення позиції чекбокса для спорту.
            labelSports.Location = new System.Drawing.Point(245, 50); // Встановлення позиції мітки для спорту.

            checkBoxTravel.Location = new System.Drawing.Point(289, 80); // Встановлення позиції чекбокса для мандрівок.
            labelTravel.Location = new System.Drawing.Point(150, 80); // Встановлення позиції мітки для мандрівок.

            checkBoxCrafting.Location = new System.Drawing.Point(291, 110); // Встановлення позиції чекбокса для майстрування.
            labelCrafting.Location = new System.Drawing.Point(95, 110); // Встановлення позиції мітки для майстрування.

            checkBoxPainting.Location = new System.Drawing.Point(332, 140); // Встановлення позиції чекбокса для малювання.
            labelPainting.Location = new System.Drawing.Point(150, 140); // Встановлення позиції мітки для малювання.
        }

        private void ButtonChoose_Click(object sender, EventArgs e) // Обробник події натискання кнопки "Вибрати".
        {
            // Логіка для обробки натискання кнопки "Вибрати".
            string selectedInterests = "Ви вибрали: "; // Ініціалізація рядка для відображення вибраних інтересів.

            if (checkBoxSports.Checked) // Перевірка, чи вибрано спорт.
                selectedInterests += "Спорт "; // Додавання "Спорт" до рядка вибраних інтересів.
            if (checkBoxTravel.Checked) // Перевірка, чи вибрано мандрівки.
                selectedInterests += "Мандрівки "; // Додавання "Мандрівки" до рядка вибраних інтересів.
            if (checkBoxCrafting.Checked) // Перевірка, чи вибрано майстрування.
                selectedInterests += "Майстрування "; // Додавання "Майстрування" до рядка вибраних інтересів.
            if (checkBoxPainting.Checked) // Перевірка, чи вибрано малювання.
                selectedInterests += "Малювання "; // Додавання "Малювання" до рядка вибраних інтересів.

            MessageBox.Show(selectedInterests); // Відображення вибраних інтересів у вікні повідомлення.
        }

        private void ButtonRefuse_Click(object sender, EventArgs e) // Обробник події натискання кнопки "Відмовитися".
        {
            // Логіка для обробки натискання кнопки "Відмовитися".
            checkBoxSports.Checked = false; // Зняття вибору з чекбокса для спорту.
            checkBoxTravel.Checked = false; // Зняття вибору з чекбокса для мандрівок.
            checkBoxCrafting.Checked = false; // Зняття вибору з чекбокса для майстрування.
            checkBoxPainting.Checked = false; // Зняття вибору з чекбокса для малювання.

            MessageBox.Show("Ви відмовилися від вибору."); // Відображення повідомлення про відмову від вибору.
        }
    }
}
