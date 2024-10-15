using System;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
            CenterButtons(); // ����������� ������
        }

        // ����� ��� ����������� ������
        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width; // ������ �����
            int formHeight = this.ClientSize.Height; // ������ �����

            // ������������ ������� ������
            button1.Location = new System.Drawing.Point((formWidth / 2) - 150, (formHeight / 2) - 25);
            button2.Location = new System.Drawing.Point((formWidth / 2) - 50, (formHeight / 2) - 25);
            button3.Location = new System.Drawing.Point((formWidth / 2) + 50, (formHeight / 2) - 25);
        }

        // ������� �������� ���� �� ������
        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button; // ���������� �� ������
            if (button != null) // ��������
            {
                // ���� ������ ������
                if (button.Text.Contains("Button"))
                {
                    button.Text = button.Text.Replace("Button", "Hovered"); // ��� ��������
                }
                else if (button.Text.Contains("Hovered"))
                {
                    button.Text = button.Text.Replace("Hovered", "Button"); // ��� �����
                }
            }
        }
    }
}
