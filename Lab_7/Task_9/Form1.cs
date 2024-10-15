using System;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        // Оригінальні тексти для полів
        private string originalText1;
        private string originalText2;
        private string originalText3;
        // Перемикачі для тексту
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

            // Прив'язуємо обробники подій
            textBox1.Enter += (s, e) => TextBox1_Enter();
            textBox1.Leave += (s, e) => TextBox1_Leave();
            textBox2.Enter += (s, e) => TextBox2_Enter();
            textBox2.Leave += (s, e) => TextBox2_Leave();
            textBox3.Enter += (s, e) => TextBox3_Enter();
            textBox3.Leave += (s, e) => TextBox3_Leave();
        }

        // Обробник входу для textBox1
        private void TextBox1_Enter()
        {
            textBox1.Text = toggle1 ? "Текст 1" : "Текст 2"; // Перемикаємо текст
            toggle1 = !toggle1; // Змінюємо стан
        }

        // Обробник виходу для textBox1
        private void TextBox1_Leave()
        {
            textBox1.Text = originalText1; // Повертаємо текст
        }

        // Обробник входу для textBox2
        private void TextBox2_Enter()
        {
            textBox2.Text = toggle2 ? "Текст 3" : "Текст 4"; // Перемикаємо текст
            toggle2 = !toggle2; // Змінюємо стан
        }

        // Обробник виходу для textBox2
        private void TextBox2_Leave()
        {
            textBox2.Text = originalText2; // Повертаємо текст
        }

        // Обробник входу для textBox3
        private void TextBox3_Enter()
        {
            textBox3.Text = toggle3 ? "Текст 5" : "Текст 6"; // Перемикаємо текст
            toggle3 = !toggle3; // Змінюємо стан
        }

        // Обробник виходу для textBox3
        private void TextBox3_Leave()
        {
            textBox3.Text = originalText3; // Повертаємо текст
        }
    }
}
