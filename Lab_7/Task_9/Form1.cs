using System;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        // ��������� ������ ��� ����
        private string originalText1;
        private string originalText2;
        private string originalText3;
        // ���������� ��� ������
        private bool toggle1 = false;
        private bool toggle2 = false;
        private bool toggle3 = false;

        public Form1()
        {
            InitializeComponent(); 

            // ���������� ������� ����
            textBox1.Text = "����� A";
            textBox2.Text = "����� B";
            textBox3.Text = "����� C";

            // �������� ��������� ������
            originalText1 = textBox1.Text;
            originalText2 = textBox2.Text;
            originalText3 = textBox3.Text;

            // ����'����� ��������� ����
            textBox1.Enter += (s, e) => TextBox1_Enter();
            textBox1.Leave += (s, e) => TextBox1_Leave();
            textBox2.Enter += (s, e) => TextBox2_Enter();
            textBox2.Leave += (s, e) => TextBox2_Leave();
            textBox3.Enter += (s, e) => TextBox3_Enter();
            textBox3.Leave += (s, e) => TextBox3_Leave();
        }

        // �������� ����� ��� textBox1
        private void TextBox1_Enter()
        {
            textBox1.Text = toggle1 ? "����� 1" : "����� 2"; // ���������� �����
            toggle1 = !toggle1; // ������� ����
        }

        // �������� ������ ��� textBox1
        private void TextBox1_Leave()
        {
            textBox1.Text = originalText1; // ��������� �����
        }

        // �������� ����� ��� textBox2
        private void TextBox2_Enter()
        {
            textBox2.Text = toggle2 ? "����� 3" : "����� 4"; // ���������� �����
            toggle2 = !toggle2; // ������� ����
        }

        // �������� ������ ��� textBox2
        private void TextBox2_Leave()
        {
            textBox2.Text = originalText2; // ��������� �����
        }

        // �������� ����� ��� textBox3
        private void TextBox3_Enter()
        {
            textBox3.Text = toggle3 ? "����� 5" : "����� 6"; // ���������� �����
            toggle3 = !toggle3; // ������� ����
        }

        // �������� ������ ��� textBox3
        private void TextBox3_Leave()
        {
            textBox3.Text = originalText3; // ��������� �����
        }
    }
}
