using System; // Підключаємо простір імен System, що містить основні функції .NET
using System.Windows.Forms; // Підключаємо простір імен для роботи з Windows Forms

namespace Task__8 // Оголошуємо простір імен для проекту
{
    public partial class Form1 : Form // Оголошуємо клас Form1, який є частиною форми
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent();  // Ініціалізуємо компоненти форми

            // Створюємо контекстне меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Елементи 1-го рівня меню
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1"); // Створюємо пункт меню Item1
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2"); // Створюємо пункт меню Item2
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3"); // Створюємо пункт меню Item3
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4"); // Створюємо пункт меню Item4

            // Додаємо елементи першого рівня в контекстне меню
            contextMenu.Items.Add(item1); // Додаємо Item1 до контекстного меню
            contextMenu.Items.Add(item2); // Додаємо Item2 до контекстного меню
            contextMenu.Items.Add(item3); // Додаємо Item3 до контекстного меню
            contextMenu.Items.Add(item4); // Додаємо Item4 до контекстного меню

            // Створюємо елементи 2-го рівня для Item2
            ToolStripMenuItem item21 = new ToolStripMenuItem("Item21"); // Створюємо підменю Item21
            ToolStripMenuItem item22 = new ToolStripMenuItem("Item22"); // Створюємо підменю Item22
            ToolStripMenuItem item23 = new ToolStripMenuItem("Item23"); // Створюємо підменю Item23
            item2.DropDownItems.Add(item21); // Додаємо елементи підменю до Item2
            item2.DropDownItems.Add(item22);
            item2.DropDownItems.Add(item23);

            // Створюємо елементи 2-го рівня для Item3
            ToolStripMenuItem item31 = new ToolStripMenuItem("Item31"); // Створюємо підменю Item31
            ToolStripMenuItem item32 = new ToolStripMenuItem("Item32"); // Створюємо підменю Item32
            ToolStripMenuItem item33 = new ToolStripMenuItem("Item33"); // Створюємо підменю Item33
            item3.DropDownItems.Add(item31); // Додаємо елементи підменю до Item3
            item3.DropDownItems.Add(item32);
            item3.DropDownItems.Add(item33);

            // Створюємо елементи 2-го рівня для Item4
            ToolStripMenuItem item41 = new ToolStripMenuItem("Item41"); // Створюємо підменю Item41
            ToolStripMenuItem item42 = new ToolStripMenuItem("Item42"); // Створюємо підменю Item42
            ToolStripMenuItem item43 = new ToolStripMenuItem("Item43"); // Створюємо підменю Item43
            ToolStripMenuItem item44 = new ToolStripMenuItem("Item44"); // Створюємо підменю Item44
            ToolStripMenuItem item45 = new ToolStripMenuItem("Item45"); // Створюємо підменю Item45
            ToolStripMenuItem item46 = new ToolStripMenuItem("Item46"); // Створюємо підменю Item46
            item4.DropDownItems.Add(item41); // Додаємо елементи підменю до Item4
            item4.DropDownItems.Add(item42);
            item4.DropDownItems.Add(item43);
            item4.DropDownItems.Add(item44);
            item4.DropDownItems.Add(item45);
            item4.DropDownItems.Add(item46);

            // Прив'язуємо контекстне меню до міток
            label1.ContextMenuStrip = contextMenu; // Прив'язуємо контекстне меню до label1
            label2.ContextMenuStrip = contextMenu; // Прив'язуємо контекстне меню до label2
            label3.ContextMenuStrip = contextMenu; // Прив'язуємо контекстне меню до label3

            // Додаємо обробку подій для кожного пункту меню
            AttachMenuEventHandlers(item1, "Item1"); 
            AttachMenuEventHandlers(item21, "Item21"); 
            AttachMenuEventHandlers(item22, "Item22"); 
            AttachMenuEventHandlers(item23, "Item23");
            AttachMenuEventHandlers(item31, "Item31"); 
            AttachMenuEventHandlers(item32, "Item32"); 
            AttachMenuEventHandlers(item33, "Item33"); 
            AttachMenuEventHandlers(item41, "Item41"); 
            AttachMenuEventHandlers(item42, "Item42"); 
            AttachMenuEventHandlers(item43, "Item43"); 
            AttachMenuEventHandlers(item44, "Item44"); 
            AttachMenuEventHandlers(item45, "Item45"); 
            AttachMenuEventHandlers(item46, "Item46"); 
        }

        // Метод для прив'язки обробників подій до елементів меню
        private void AttachMenuEventHandlers(ToolStripMenuItem menuItem, string itemName)
        {
            // Прив'язуємо обробник події Click, який викликає метод ShowMessage
            menuItem.Click += (s, e) => ShowMessage(itemName); // Додаємо анонімний обробник події
        }

        // Метод для показу повідомлення при кліку на пункт меню
        private void ShowMessage(string itemName)
        {
            // Відображаємо повідомлення про те, що пункт меню було натиснуто
            MessageBox.Show($"{itemName} clicked"); // Виводимо вікно повідомлення
        }
    }
}
