using System;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ��������� ������������ ����
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // ������ ����
            ToolStripMenuItem swap1And2 = new ToolStripMenuItem("Swap Label 1 and Label 2");
            ToolStripMenuItem swap2And3 = new ToolStripMenuItem("Swap Label 2 and Label 3");
            ToolStripMenuItem swap1And3 = new ToolStripMenuItem("Swap Label 1 and Label 3");

            // ��������� ������ �� ����
            contextMenu.Items.Add(swap1And2);
            contextMenu.Items.Add(swap2And3);
            contextMenu.Items.Add(swap1And3);

            // ����'���� ���� �� ����
            label1.ContextMenuStrip = contextMenu;
            label2.ContextMenuStrip = contextMenu;
            label3.ContextMenuStrip = contextMenu;

            // ������� ���� ��� ������ ����
            swap1And2.Click += SwapLabels;
            swap2And3.Click += SwapLabels;
            swap1And3.Click += SwapLabels;
        }

        // �������� ���� ��� ������ ����
        private void SwapLabels(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem; // ��������� ��'���� �� �������� ����
            if (clickedItem != null)
            {
                // ����������, �� ���� �������
                if (clickedItem.Text == "Swap Label 1 and Label 2")
                {
                    SwapLabelText(this.label1, this.label2);
                }
                else if (clickedItem.Text == "Swap Label 2 and Label 3")
                {
                    SwapLabelText(this.label2, this.label3);
                }
                else if (clickedItem.Text == "Swap Label 1 and Label 3")
                {
                    SwapLabelText(this.label1, this.label3);
                }
            }
        }

        // ����� ��� ����� ������� �� ������
        private void SwapLabelText(System.Windows.Forms.Label labelA, System.Windows.Forms.Label labelB)
        {
            string temp = labelA.Text; // �������� ����� ���� A
            labelA.Text = labelB.Text; // ���� �������
            labelB.Text = temp; // ���������� �����
        }
    }
}
