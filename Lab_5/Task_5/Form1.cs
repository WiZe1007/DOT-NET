using System; // Підключення простору імен System, що містить базові класи .NET
using System.Drawing; // Підключення простору імен для роботи з графікою та зображеннями
using System.Windows.Forms; // Підключення простору імен для створення та роботи з формами Windows Forms

namespace WinFormsApp1 // Оголошення простору імен для цього додатку
{
    public partial class Form1 : Form // Оголошення класу Form1, який є частковим класом і успадковується від класу Form
    {
        public Form1() // Конструктор класу Form1
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            // Ініціалізація PictureBox елементів перенесено до методу InitializeComponent
        }
    }
}
