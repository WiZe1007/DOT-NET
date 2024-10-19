using System;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ��������� ��������� ���� �� �������� ����
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                AddClickEventToMenuItems(menuItem);
            }
        }

        // ����������� ����� ��� ��������� ��������� ����
        private void AddClickEventToMenuItems(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
            {
                // ���� ������� ��� ������
                if (subItem.DropDownItems.Count == 0)
                {
                    subItem.Click += MenuItem_Click; // ��������� ���������
                }
                else
                {
                    // ���������� ��� ��������
                    AddClickEventToMenuItems(subItem);
                }
            }
        }

        // �������� ���� ��� ����
        private void MenuItem_Click(object sender, EventArgs e)
        {
            // ��������� ������ ����
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                // ³���������� ����� ��������
                MessageBox.Show(clickedItem.Text, "������� ����� ����");
            }
        }
    }
}
