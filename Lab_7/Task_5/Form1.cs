using System;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
            CenterButtons(); // ����������� ������ �� ����
            InitializeButtonEvents(); // ������������ ��������� ���� ��� ������
        }

        // ����������� ������ � ���
        private void CenterButtons()
        {
            int formWidth = this.ClientSize.Width; // ������ �����
            int formHeight = this.ClientSize.Height; // ������ �����

            // ���������� ������� ������
            button1.Location = new System.Drawing.Point((formWidth / 2) - 150, (formHeight / 2) - 25);
            button2.Location = new System.Drawing.Point((formWidth / 2) - 50, (formHeight / 2) - 25);
            button3.Location = new System.Drawing.Point((formWidth / 2) + 50, (formHeight / 2) - 25);
        }

        // ������������ ��������� ���� ��� ������
        private void InitializeButtonEvents()
        {
            // ��������� ��������� ��� ���� MouseEnter �� MouseLeave
            button1.MouseEnter += (s, e) => ToggleButtonText(button1);
            button1.MouseLeave += (s, e) => ToggleButtonText(button1);
            button2.MouseEnter += (s, e) => ToggleButtonText(button2);
            button2.MouseLeave += (s, e) => ToggleButtonText(button2);
            button3.MouseEnter += (s, e) => ToggleButtonText(button3);
            button3.MouseLeave += (s, e) => ToggleButtonText(button3);
        }

        // ����������� ������ ������ ��� ��������
        private void ToggleButtonText(Button button)
        {
            button.Text = button.Text.Contains("Hovered") ?
                button.Text.Replace("Hovered", "Button") :
                button.Text.Replace("Button", "Hovered");
        }
    }
}
