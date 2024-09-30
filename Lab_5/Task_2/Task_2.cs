using System; // Підключення простору імен System для основних функцій
using System.Drawing; // Підключення простору імен для роботи з графікою та кольорами
using System.Windows.Forms; // Підключення простору імен для створення Windows Forms додатків

public class Task_2 : Form // Оголошення класу Task_2, який наслідує клас Form (створює вікно)
{
    public Task_2() // Конструктор класу Task_2
    {
        // Налаштування заголовку форми
        this.Text = "Task_2";
        // Встановлення розміру форми
        this.Size = new Size(400, 300);
        // Додаємо обробник події завантаження форми
        this.Load += new EventHandler(Form_Load);
    }

    private void Form_Load(object sender, EventArgs e) // Метод, що викликається при завантаженні форми
    {
        // Створюємо перший рядок
        System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
        label1.Text = "Перший рядок"; // Встановлюємо текст для першого рядка
        label1.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold | FontStyle.Italic); // Встановлюємо шрифт, стиль жирний + курсив
        label1.ForeColor = Color.Pink; // Встановлюємо колір тексту рожевим
        label1.BackColor = Color.Green; // Встановлюємо зелений колір фону
        label1.TextAlign = ContentAlignment.MiddleLeft; // Вирівнювання тексту зліва
        label1.Dock = DockStyle.Top; // Розташування елемента зверху форми

        // Створюємо другий рядок
        System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
        label2.Text = "Другий рядок"; // Встановлюємо текст для другого рядка
        label2.Font = new System.Drawing.Font("Arial", 14, FontStyle.Italic | FontStyle.Underline); // Шрифт курсив + підкреслення
        label2.ForeColor = Color.Blue; // Встановлюємо синій колір тексту
        label2.BackColor = Color.Red; // Встановлюємо червоний колір фону
        label2.TextAlign = ContentAlignment.MiddleRight; // Вирівнювання тексту справа
        label2.Dock = DockStyle.Top; // Розташування елемента зверху форми

        // Створюємо третій рядок
        System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
        label3.Text = "Третій рядок"; // Встановлюємо текст для третього рядка
        label3.Font = new System.Drawing.Font("Arial", 17, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); // Стиль жирний + курсив + підкреслення
        label3.ForeColor = Color.LightBlue; // Встановлюємо світло-блакитний колір тексту
        label3.BackColor = Color.Yellow; // Встановлюємо жовтий колір фону
        label3.TextAlign = ContentAlignment.MiddleCenter; // Вирівнювання тексту по центру
        label3.Dock = DockStyle.Top; // Розташування елемента зверху форми

        // Додаємо рядки до форми у зворотньому порядку для правильного відображення
        this.Controls.Add(label3); // Додаємо третій рядок
        this.Controls.Add(label2); // Додаємо другий рядок
        this.Controls.Add(label1); // Додаємо перший рядок
    }

    [STAThread] // Атрибут для запуску програми в однопоточному режимі
    public static void Main() // Основний метод програми
    {
        Application.EnableVisualStyles(); // Включає візуальні стилі для елементів
        System.Windows.Forms.Application.Run(new Task_2()); // Запускає форму Task_2
    }
}

