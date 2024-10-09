using System; // Підключення простору імен для загальних класів, таких як DateTime
using System.Windows.Forms; // Підключення простору імен для класів Windows Forms

namespace Task_3 // Оголошення простору імен для організації коду
{
    public partial class Form1 : Form // Оголошення класу Form1, який успадковує клас Form
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Виклик методу ініціалізації компонентів форми
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // Метод-обробник події натискання кнопки "Відправити"
        {
            // Логіка для обробки натискання кнопки "Відправити"
            MessageBox.Show("Дані відправлено!"); // Відображення повідомлення, що дані відправлено
        }

        private void ButtonReset_Click(object sender, EventArgs e) // Метод-обробник події натискання кнопки "Скинути"
        {
            // Логіка для обробки натискання кнопки "Скинути"
            textBoxName.Clear(); // Очищення текстового поля для імені
            textBoxPhone.Clear(); // Очищення текстового поля для телефону
            textBoxEmail.Clear(); // Очищення текстового поля для електронної пошти
            dateTimePickerDOB.Value = DateTime.Now; // Скидання контролю вибору дати на сьогоднішню дату
        }
    }
}
