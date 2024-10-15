using System;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        // Змінні для оригінального тексту та перемикачів
        private string originalText1;
        private string originalText2;
        private string originalText3;
        private bool toggle1 = false;
        private bool toggle2 = false;
        private bool toggle3 = false;

        public Form1()
        {
            InitializeComponent();
            // Заповнюємо текстові поля
            textBox1.Text = "Текст A";
            textBox2.Text = "Текст B";
            textBox3.Text = "Текст C";

            // Зберігаємо оригінальні тексти
            originalText1 = textBox1.Text;
            originalText2 = textBox2.Text;
            originalText3 = textBox3.Text;

            // Прив'язка обробників подій
            textBox1.Enter += new EventHandler(this.textBox_EnterLeave);
            textBox1.Leave += new EventHandler(this.textBox_EnterLeave);
            textBox2.Enter += new EventHandler(this.textBox_EnterLeave);
            textBox2.Leave += new EventHandler(this.textBox_EnterLeave);
            textBox3.Enter += new EventHandler(this.textBox_EnterLeave);
            textBox3.Leave += new EventHandler(this.textBox_EnterLeave);
        }

        // Обробка подій фокусу
        private void textBox_EnterLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                if (textBox.Focused) // Якщо фокус на текстовому полі
                {
                    // Зміна тексту за умовами
                    if (textBox == textBox1)
                    {
                        textBox.Text = toggle1 ? "Текст 1" : "Текст 2";
                        toggle1 = !toggle1;
                    }
                    else if (textBox == textBox2)
                    {
                        textBox.Text = toggle2 ? "Текст 3" : "Текст 4";
                        toggle2 = !toggle2;
                    }
                    else if (textBox == textBox3)
                    {
                        textBox.Text = toggle3 ? "Текст 5" : "Текст 6";
                        toggle3 = !toggle3;
                    }
                }
                else // Якщо фокус втрачається
                {
                    // Відновлення оригінального тексту
                    if (textBox == textBox1)
                    {
                        textBox.Text = originalText1;
                    }
                    else if (textBox == textBox2)
                    {
                        textBox.Text = originalText2;
                    }
                    else if (textBox == textBox3)
                    {
                        textBox.Text = originalText3;
                    }
                }
            }
        }
    }
}
