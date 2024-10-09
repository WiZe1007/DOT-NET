using System; // Підключення простору імен System для загальних функціональностей.
using System.Windows.Forms; // Підключення простору імен для використання елементів графічного інтерфейсу Windows Forms.

namespace Task__8 // Оголошення простору імен Task__8.
{
    public partial class Form1 : Form // Оголошення класу Form1, що успадковується від класу Form (форма).
    {
        public Form1() // Конструктор класу Form1.
        {
            InitializeComponent(); // Ініціалізація компонентів форми.

            // Створюємо контекстне меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Елементи 1-го рівня
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1"); // Створення пункту меню "Item1".
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2"); // Створення пункту меню "Item2".
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3"); // Створення пункту меню "Item3".
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4"); // Створення пункту меню "Item4".

            // Додаємо елементи першого рівня в контекстне меню
            contextMenu.Items.Add(item1); // Додавання елемента "Item1" в контекстне меню.
            contextMenu.Items.Add(item2); // Додавання елемента "Item2" в контекстне меню.
            contextMenu.Items.Add(item3); // Додавання елемента "Item3" в контекстне меню.
            contextMenu.Items.Add(item4); // Додавання елемента "Item4" в контекстне меню.

            // Елементи 2-го рівня для Item2
            ToolStripMenuItem item21 = new ToolStripMenuItem("Item21"); // Створення підпункту "Item21" для "Item2".
            ToolStripMenuItem item22 = new ToolStripMenuItem("Item22"); // Створення підпункту "Item22" для "Item2".
            ToolStripMenuItem item23 = new ToolStripMenuItem("Item23"); // Створення підпункту "Item23" для "Item2".
            item2.DropDownItems.Add(item21); // Додавання "Item21" як підпункту до "Item2".
            item2.DropDownItems.Add(item22); // Додавання "Item22" як підпункту до "Item2".
            item2.DropDownItems.Add(item23); // Додавання "Item23" як підпункту до "Item2".

            // Елементи 2-го рівня для Item3
            ToolStripMenuItem item31 = new ToolStripMenuItem("Item31"); // Створення підпункту "Item31" для "Item3".
            ToolStripMenuItem item32 = new ToolStripMenuItem("Item32"); // Створення підпункту "Item32" для "Item3".
            ToolStripMenuItem item33 = new ToolStripMenuItem("Item33"); // Створення підпункту "Item33" для "Item3".
            item3.DropDownItems.Add(item31); // Додавання "Item31" як підпункту до "Item3".
            item3.DropDownItems.Add(item32); // Додавання "Item32" як підпункту до "Item3".
            item3.DropDownItems.Add(item33); // Додавання "Item33" як підпункту до "Item3".

            // Елементи 2-го рівня для Item4
            ToolStripMenuItem item41 = new ToolStripMenuItem("Item41"); // Створення підпункту "Item41" для "Item4".
            ToolStripMenuItem item42 = new ToolStripMenuItem("Item42"); // Створення підпункту "Item42" для "Item4".
            ToolStripMenuItem item43 = new ToolStripMenuItem("Item43"); // Створення підпункту "Item43" для "Item4".
            ToolStripMenuItem item44 = new ToolStripMenuItem("Item44"); // Створення підпункту "Item44" для "Item4".
            ToolStripMenuItem item45 = new ToolStripMenuItem("Item45"); // Створення підпункту "Item45" для "Item4".
            ToolStripMenuItem item46 = new ToolStripMenuItem("Item46"); // Створення підпункту "Item46" для "Item4".
            item4.DropDownItems.Add(item41); // Додавання "Item41" як підпункту до "Item4".
            item4.DropDownItems.Add(item42); // Додавання "Item42" як підпункту до "Item4".
            item4.DropDownItems.Add(item43); // Додавання "Item43" як підпункту до "Item4".
            item4.DropDownItems.Add(item44); // Додавання "Item44" як підпункту до "Item4".
            item4.DropDownItems.Add(item45); // Додавання "Item45" як підпункту до "Item4".
            item4.DropDownItems.Add(item46); // Додавання "Item46" як підпункту до "Item4".

            // Прив'язуємо контекстне меню до міток
            label1.ContextMenuStrip = contextMenu; // Прив'язуємо контекстне меню до label1.
            label2.ContextMenuStrip = contextMenu; // Прив'язуємо контекстне меню до label2.
            label3.ContextMenuStrip = contextMenu; // Прив'язуємо контекстне меню до label3.

            // Додаємо обробку подій для кожного пункту меню
            item1.Click += (s, e) => MessageBox.Show("Item1 clicked"); // Додаємо обробник події для натискання на "Item1".
            item21.Click += (s, e) => MessageBox.Show("Item21 clicked"); // Додаємо обробник події для натискання на "Item21".
            item22.Click += (s, e) => MessageBox.Show("Item22 clicked"); // Додаємо обробник події для натискання на "Item22".
            item23.Click += (s, e) => MessageBox.Show("Item23 clicked"); // Додаємо обробник події для натискання на "Item23".

            item31.Click += (s, e) => MessageBox.Show("Item31 clicked"); // Додаємо обробник події для натискання на "Item31".
            item32.Click += (s, e) => MessageBox.Show("Item32 clicked"); // Додаємо обробник події для натискання на "Item32".
            item33.Click += (s, e) => MessageBox.Show("Item33 clicked"); // Додаємо обробник події для натискання на "Item33".

            item41.Click += (s, e) => MessageBox.Show("Item41 clicked"); // Додаємо обробник події для натискання на "Item41".
            item42.Click += (s, e) => MessageBox.Show("Item42 clicked"); // Додаємо обробник події для натискання на "Item42".
            item43.Click += (s, e) => MessageBox.Show("Item43 clicked"); // Додаємо обробник події для натискання на "Item43".
            item44.Click += (s, e) => MessageBox.Show("Item44 clicked"); // Додаємо обробник події для натискання на "Item44".
            item45.Click += (s, e) => MessageBox.Show("Item45 clicked"); // Додаємо обробник події для натискання на "Item45".
            item46.Click += (s, e) => MessageBox.Show("Item46 clicked"); // Додаємо обробник події для натискання на "Item46".
        }
    }
}
