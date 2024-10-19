using System;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // ������ ��� �������� ������
        private bool isButtonVisible; // ���� �������� ������

        public Form1()
        {
            InitializeComponent(); 
            InitializeTimer(); // ������������ �������
            isButtonVisible = true; 
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer(); // ��������� �������
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick; // ������� ��䳿 Tick
            // ������ �� ����������� �����������
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // ���������� �������� ������
            isButtonVisible = !isButtonVisible;
            button1.Visible = isButtonVisible; // ��������� �������� ������
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Interval = (int)intervalNumericUpDown.Value; // ��������� ���������
            timer.Start(); // ������ �������
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop(); // ������� �������
        }
    }
}
