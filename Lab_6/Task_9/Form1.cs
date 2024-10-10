using System; // Імпортуємо базові простори імен для роботи з системними функціями
using System.Windows.Forms; // Імпортуємо простір імен для роботи з елементами форми Windows

namespace Task9 // Оголошуємо простір імен для програми
{
    public partial class Form1 : Form // Оголошуємо клас Form1, який є частковим класом і успадковується від класу Form
{
    public Form1() // Конструктор класу Form1
    {
        InitializeComponent(); // Ініціалізуємо компоненти форми (автоматично згенерований код)
                               // Додаткові налаштування або події для кнопок можна додати тут
        AddButtonHandlers(); // Викликаємо метод для прив'язки подій до кнопок
    }

    private void AddButtonHandlers() // Метод для додавання обробників подій до кнопок
    {
        // Прив'язуємо події до кнопок
        toolStripButton1.Click += Tool1_Click; // Прив'язуємо обробник Tool1_Click до події натискання кнопки toolStripButton1
        toolStripButton2.Click += Tool2_Click; // Прив'язуємо обробник Tool2_Click до події натискання кнопки toolStripButton2
        toolStripButton3.Click += Tool3_Click; // Прив'язуємо обробник Tool3_Click до події натискання кнопки toolStripButton3
        toolStripButton4.Click += Tool4_Click; // Прив'язуємо обробник Tool4_Click до події натискання кнопки toolStripButton4
    }

    // Обробники подій для кнопок
    private void Tool1_Click(object sender, EventArgs e) // Обробник події для кнопки toolStripButton1
    {
        MessageBox.Show("Натиснута кнопка Tool1"); // Виводимо повідомлення при натисканні кнопки
    }

    private void Tool2_Click(object sender, EventArgs e) // Обробник події для кнопки toolStripButton2
    {
        MessageBox.Show("Натиснута кнопка Tool2"); // Виводимо повідомлення при натисканні кнопки
    }

    private void Tool3_Click(object sender, EventArgs e) // Обробник події для кнопки toolStripButton3
    {
        MessageBox.Show("Натиснута кнопка Tool3"); // Виводимо повідомлення при натисканні кнопки
    }

    private void Tool4_Click(object sender, EventArgs e) // Обробник події для кнопки toolStripButton4
    {
        MessageBox.Show("Натиснута кнопка Tool4"); // Виводимо повідомлення при натисканні кнопки
    }
}

}