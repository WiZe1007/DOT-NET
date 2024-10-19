using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // ����������� ����������

            // ��������� ������������ ����
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // ��������� ������ ����
            ToolStripMenuItem swap1And2 = new ToolStripMenuItem("Swap Label 1 and Label 2");
            ToolStripMenuItem swap2And3 = new ToolStripMenuItem("Swap Label 2 and Label 3");
            ToolStripMenuItem swap1And3 = new ToolStripMenuItem("Swap Label 1 and Label 3");

            // ��������� ������ ���� �� ������������ ����
            contextMenu.Items.Add(swap1And2);
            contextMenu.Items.Add(swap2And3);
            contextMenu.Items.Add(swap1And3);

            // ����'���� ������������ ���� �� ����
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;

            // ��������� ��������� ���� ��� ������ ����
            swap1And2.Click += (s, e) => SwapLabelText(label1, label2);
            swap2And3.Click += (s, e) => SwapLabelText(label2, label3);
            swap1And3.Click += (s, e) => SwapLabelText(label1, label3);
        }

        // ����� ��� ����� ������� �� ������
        private void SwapLabelText(System.Windows.Forms.Label labelA, System.Windows.Forms.Label labelB)
        {
            string temp = labelA.Text; // ���������� ������ 1 ����
            labelA.Text = labelB.Text; // ��������� ������ � 2 ���� 1
            labelB.Text = temp; // ������������ ������ 1 ���� 2
        }
    }
}
