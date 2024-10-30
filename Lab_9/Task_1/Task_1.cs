using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Task_1 : Form
    {
        private const decimal ExchangeRate = 11.79m; // ���� �����

        public Task_1()
        {
            InitializeComponent();
            button1.Enabled = false; // ������ �������� ���������

            // ϳ������ �� ��䳿
            textBox1.TextChanged += (s, e) => TextBox1_TextChanged();
            button1.Click += (s, e) => Button1_Click();
        }

        private void TextBox1_TextChanged()
        {
            // �������� ������� ����� �����
            string input = textBox1.Text;
            if (!decimal.TryParse(input, out _))
            {
                textBox1.Text = string.Concat(input.Where(char.IsDigit)); // ����� ��������
                textBox1.SelectionStart = textBox1.Text.Length; // ���������� ������
            }

            // ������ ������ OK
            button1.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void Button1_Click()
        {
            // ����������� ��������
            if (decimal.TryParse(textBox1.Text, out decimal amountUah))
            {
                decimal result = amountUah * ExchangeRate; // ����������
                label2.Text = $"{amountUah} ��� = {result:F2} ������"; // ³����������
            }
            else
            {
                label2.Text = "���������� ��������."; // �������
            }
        }
    }
}
