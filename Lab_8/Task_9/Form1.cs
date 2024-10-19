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

        private void AddButtonHandlers() // ��������� ��������� ������
        {
            // ��������� ��������� ��� ������
            RegisterButtonHandler(toolStripButton1);
            RegisterButtonHandler(toolStripButton2);
            RegisterButtonHandler(toolStripButton3);
            RegisterButtonHandler(toolStripButton4);
        }

        private void RegisterButtonHandler(ToolStripButton button) // ��������� ��������� ��� ������
        {
            button.Click += (s, e) => ShowMessage(button.Text); // ������ ����������� � ������� ������
        }

        private void ShowMessage(string buttonName) // ��������� �����������
        {
            MessageBox.Show($"��������� ������ {buttonName}"); // ������ ����������� � ������ ������
        }
    }
}
