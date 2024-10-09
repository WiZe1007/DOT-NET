using System; // Підключаємо простір імен System, який містить базові типи даних та функціональність.
using System.Windows.Forms; // Підключаємо простір імен для роботи з Windows Forms.

namespace Task_2 // Оголошення простору імен Task_2.
{
    public partial class Form1 : Form // Оголошення часткового класу Form1, який наслідує клас Form.
    {
        public Form1() // Конструктор класу Form1.
        {
            InitializeComponent(); // Викликаємо метод для ініціалізації компонентів форми.
            LoadCities(); // Викликаємо метод для завантаження міст до списків.
        }

        private void LoadCities() // Метод для завантаження міст у комбінований список і список.
        {
            string[] cities = { "Каїр", "Александрія", "Гіза", "Луксор", "Асуан" }; // Масив міст Єгипту.

            // Додавання міст до ComboBox
            comboBoxCities.Items.AddRange(cities); // Додаємо масив міст до комбінованого списку.

            // Додавання міст до ListBox
            listBoxCities.Items.AddRange(cities); // Додаємо масив міст до списку.
        }
    }
}
