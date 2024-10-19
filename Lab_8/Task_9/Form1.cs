using System;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
            AddButtonHandlers(); 
        }

        private void AddButtonHandlers() // Додавання обробників кнопок
        {
            // Реєстрація обробників для кнопок
            RegisterButtonHandler(toolStripButton1);
            RegisterButtonHandler(toolStripButton2);
            RegisterButtonHandler(toolStripButton3);
            RegisterButtonHandler(toolStripButton4);
        }

        private void RegisterButtonHandler(ToolStripButton button) // Реєстрація обробника для кнопки
        {
            button.Click += (s, e) => ShowMessage(button.Text); // Виклик повідомлення з текстом кнопки
        }

        private void ShowMessage(string buttonName) // Виведення повідомлення
        {
            MessageBox.Show($"Натиснута кнопка {buttonName}"); // Показує повідомлення з назвою кнопки
        }
    }
}
