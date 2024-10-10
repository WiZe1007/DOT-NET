using System; // ϳ�������� ������ ���� System, �� ������ ������ ������� .NET
using System.Windows.Forms; // ϳ�������� ������ ���� ��� ������ � Windows Forms

namespace Task__8 // ��������� ������ ���� ��� �������
{
    public partial class Form1 : Form // ��������� ���� Form1, ���� � �������� �����
    {
        public Form1() // ����������� ����� Form1
        {
            InitializeComponent();  // ���������� ���������� �����

            // ��������� ���������� ����
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // �������� 1-�� ���� ����
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1"); // ��������� ����� ���� Item1
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2"); // ��������� ����� ���� Item2
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3"); // ��������� ����� ���� Item3
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4"); // ��������� ����� ���� Item4

            // ������ �������� ������� ���� � ���������� ����
            contextMenu.Items.Add(item1); // ������ Item1 �� ������������ ����
            contextMenu.Items.Add(item2); // ������ Item2 �� ������������ ����
            contextMenu.Items.Add(item3); // ������ Item3 �� ������������ ����
            contextMenu.Items.Add(item4); // ������ Item4 �� ������������ ����

            // ��������� �������� 2-�� ���� ��� Item2
            ToolStripMenuItem item21 = new ToolStripMenuItem("Item21"); // ��������� ������ Item21
            ToolStripMenuItem item22 = new ToolStripMenuItem("Item22"); // ��������� ������ Item22
            ToolStripMenuItem item23 = new ToolStripMenuItem("Item23"); // ��������� ������ Item23
            item2.DropDownItems.Add(item21); // ������ �������� ������ �� Item2
            item2.DropDownItems.Add(item22);
            item2.DropDownItems.Add(item23);

            // ��������� �������� 2-�� ���� ��� Item3
            ToolStripMenuItem item31 = new ToolStripMenuItem("Item31"); // ��������� ������ Item31
            ToolStripMenuItem item32 = new ToolStripMenuItem("Item32"); // ��������� ������ Item32
            ToolStripMenuItem item33 = new ToolStripMenuItem("Item33"); // ��������� ������ Item33
            item3.DropDownItems.Add(item31); // ������ �������� ������ �� Item3
            item3.DropDownItems.Add(item32);
            item3.DropDownItems.Add(item33);

            // ��������� �������� 2-�� ���� ��� Item4
            ToolStripMenuItem item41 = new ToolStripMenuItem("Item41"); // ��������� ������ Item41
            ToolStripMenuItem item42 = new ToolStripMenuItem("Item42"); // ��������� ������ Item42
            ToolStripMenuItem item43 = new ToolStripMenuItem("Item43"); // ��������� ������ Item43
            ToolStripMenuItem item44 = new ToolStripMenuItem("Item44"); // ��������� ������ Item44
            ToolStripMenuItem item45 = new ToolStripMenuItem("Item45"); // ��������� ������ Item45
            ToolStripMenuItem item46 = new ToolStripMenuItem("Item46"); // ��������� ������ Item46
            item4.DropDownItems.Add(item41); // ������ �������� ������ �� Item4
            item4.DropDownItems.Add(item42);
            item4.DropDownItems.Add(item43);
            item4.DropDownItems.Add(item44);
            item4.DropDownItems.Add(item45);
            item4.DropDownItems.Add(item46);

            // ����'����� ���������� ���� �� ����
            label1.ContextMenuStrip = contextMenu; // ����'����� ���������� ���� �� label1
            label2.ContextMenuStrip = contextMenu; // ����'����� ���������� ���� �� label2
            label3.ContextMenuStrip = contextMenu; // ����'����� ���������� ���� �� label3

            // ������ ������� ���� ��� ������� ������ ����
            AttachMenuEventHandlers(item1, "Item1"); 
            AttachMenuEventHandlers(item21, "Item21"); 
            AttachMenuEventHandlers(item22, "Item22"); 
            AttachMenuEventHandlers(item23, "Item23");
            AttachMenuEventHandlers(item31, "Item31"); 
            AttachMenuEventHandlers(item32, "Item32"); 
            AttachMenuEventHandlers(item33, "Item33"); 
            AttachMenuEventHandlers(item41, "Item41"); 
            AttachMenuEventHandlers(item42, "Item42"); 
            AttachMenuEventHandlers(item43, "Item43"); 
            AttachMenuEventHandlers(item44, "Item44"); 
            AttachMenuEventHandlers(item45, "Item45"); 
            AttachMenuEventHandlers(item46, "Item46"); 
        }

        // ����� ��� ����'���� ��������� ���� �� �������� ����
        private void AttachMenuEventHandlers(ToolStripMenuItem menuItem, string itemName)
        {
            // ����'����� �������� ��䳿 Click, ���� ������� ����� ShowMessage
            menuItem.Click += (s, e) => ShowMessage(itemName); // ������ �������� �������� ��䳿
        }

        // ����� ��� ������ ����������� ��� ���� �� ����� ����
        private void ShowMessage(string itemName)
        {
            // ³��������� ����������� ��� ��, �� ����� ���� ���� ���������
            MessageBox.Show($"{itemName} clicked"); // �������� ���� �����������
        }
    }
}
