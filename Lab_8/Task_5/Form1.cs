using System;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ��������� ��������� ���� ��� ����
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                AddClickEventToMenuItems(menuItem);
            }
        }

        // ����������� ����� ��� ������� �������� ����
        private void AddClickEventToMenuItems(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems)
            {
                // ��������� ��������� ��� ��������
                subItem.Click += (s, e) => ShowMessage(subItem.Text);

                // ���������� ���������� ��������
                if (subItem.DropDownItems.Count > 0)
                {
                    AddClickEventToMenuItems(subItem);
                }
            }
        }

        private void ShowMessage(string itemName)
        {
            // ��������� ����� �������� � ��� �����������
            MessageBox.Show(itemName, "������� ����� ����");
        }
    }
}
