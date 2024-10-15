using System;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������
            InitializeButtons(); // ������ ������ ��� ��������� ������
            displayTimer.Tick += (s, e) => DisplayTimer_Tick(); // ϳ��������� ��������� ��䳿 �������
        }

        private void InitializeButtons()
        {
            // ��������� ������ ��� ����������
            Button button1 = new Button();
            Button button2 = new Button();
            Button button3 = new Button();

            // ������������ ������ �� �������
            button1.Text = "������ 1";
            button2.Text = "������ 2";
            button3.Text = "������ 3";

            // ������������ ������ ������
            int buttonWidth = 100;
            int buttonHeight = 30;
            button1.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button2.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            button3.Size = new System.Drawing.Size(buttonWidth, buttonHeight);

            // ���������� ������� ������ �� ����
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int spacing = 10;

            // ���������� ������� ��� ������
            button1.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, (formHeight - (3 * buttonHeight + 2 * spacing)) / 2);
            button2.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, button1.Location.Y + buttonHeight + spacing);
            button3.Location = new System.Drawing.Point((formWidth - buttonWidth) / 2, button2.Location.Y + buttonHeight + spacing);

            // ��������� ��������� ���� ��� ������
            button1.Click += (s, e) => ShowMessage("������ 1"); 
            button2.Click += (s, e) => ShowMessage("������ 2"); 
            button3.Click += (s, e) => ShowMessage("������ 3"); 

            // ��������� ������ �� �����
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
        }

        private void ShowMessage(string buttonText)
        {
            // ³���������� ������ �� ���� �� ����� �����
            displayLabel.Text = $"�� ���������: {buttonText}";
            displayPanel.Visible = true; // �������� ������
            displayTimer.Start(); // ��������� ������ ��� ������� ��������
        }

        private void DisplayTimer_Tick()
        {
            // �������� ������ ���� � ������������ �����
            displayLabel.Text = string.Empty; // ������� ������
            displayPanel.Visible = false; // ������� ������
            displayTimer.Stop(); // ������� �������
        }
    }
}
