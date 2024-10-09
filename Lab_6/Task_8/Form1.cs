using System; // ϳ��������� �������� ���� System ��� ��������� �����������������.
using System.Windows.Forms; // ϳ��������� �������� ���� ��� ������������ �������� ���������� ���������� Windows Forms.

namespace Task__8 // ���������� �������� ���� Task__8.
{
    public partial class Form1 : Form // ���������� ����� Form1, �� ������������� �� ����� Form (�����).
    {
        public Form1() // ����������� ����� Form1.
        {
            InitializeComponent(); // ����������� ���������� �����.

            // ��������� ���������� ����
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // �������� 1-�� ����
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item1"); // ��������� ������ ���� "Item1".
            ToolStripMenuItem item2 = new ToolStripMenuItem("Item2"); // ��������� ������ ���� "Item2".
            ToolStripMenuItem item3 = new ToolStripMenuItem("Item3"); // ��������� ������ ���� "Item3".
            ToolStripMenuItem item4 = new ToolStripMenuItem("Item4"); // ��������� ������ ���� "Item4".

            // ������ �������� ������� ���� � ���������� ����
            contextMenu.Items.Add(item1); // ��������� �������� "Item1" � ���������� ����.
            contextMenu.Items.Add(item2); // ��������� �������� "Item2" � ���������� ����.
            contextMenu.Items.Add(item3); // ��������� �������� "Item3" � ���������� ����.
            contextMenu.Items.Add(item4); // ��������� �������� "Item4" � ���������� ����.

            // �������� 2-�� ���� ��� Item2
            ToolStripMenuItem item21 = new ToolStripMenuItem("Item21"); // ��������� �������� "Item21" ��� "Item2".
            ToolStripMenuItem item22 = new ToolStripMenuItem("Item22"); // ��������� �������� "Item22" ��� "Item2".
            ToolStripMenuItem item23 = new ToolStripMenuItem("Item23"); // ��������� �������� "Item23" ��� "Item2".
            item2.DropDownItems.Add(item21); // ��������� "Item21" �� �������� �� "Item2".
            item2.DropDownItems.Add(item22); // ��������� "Item22" �� �������� �� "Item2".
            item2.DropDownItems.Add(item23); // ��������� "Item23" �� �������� �� "Item2".

            // �������� 2-�� ���� ��� Item3
            ToolStripMenuItem item31 = new ToolStripMenuItem("Item31"); // ��������� �������� "Item31" ��� "Item3".
            ToolStripMenuItem item32 = new ToolStripMenuItem("Item32"); // ��������� �������� "Item32" ��� "Item3".
            ToolStripMenuItem item33 = new ToolStripMenuItem("Item33"); // ��������� �������� "Item33" ��� "Item3".
            item3.DropDownItems.Add(item31); // ��������� "Item31" �� �������� �� "Item3".
            item3.DropDownItems.Add(item32); // ��������� "Item32" �� �������� �� "Item3".
            item3.DropDownItems.Add(item33); // ��������� "Item33" �� �������� �� "Item3".

            // �������� 2-�� ���� ��� Item4
            ToolStripMenuItem item41 = new ToolStripMenuItem("Item41"); // ��������� �������� "Item41" ��� "Item4".
            ToolStripMenuItem item42 = new ToolStripMenuItem("Item42"); // ��������� �������� "Item42" ��� "Item4".
            ToolStripMenuItem item43 = new ToolStripMenuItem("Item43"); // ��������� �������� "Item43" ��� "Item4".
            ToolStripMenuItem item44 = new ToolStripMenuItem("Item44"); // ��������� �������� "Item44" ��� "Item4".
            ToolStripMenuItem item45 = new ToolStripMenuItem("Item45"); // ��������� �������� "Item45" ��� "Item4".
            ToolStripMenuItem item46 = new ToolStripMenuItem("Item46"); // ��������� �������� "Item46" ��� "Item4".
            item4.DropDownItems.Add(item41); // ��������� "Item41" �� �������� �� "Item4".
            item4.DropDownItems.Add(item42); // ��������� "Item42" �� �������� �� "Item4".
            item4.DropDownItems.Add(item43); // ��������� "Item43" �� �������� �� "Item4".
            item4.DropDownItems.Add(item44); // ��������� "Item44" �� �������� �� "Item4".
            item4.DropDownItems.Add(item45); // ��������� "Item45" �� �������� �� "Item4".
            item4.DropDownItems.Add(item46); // ��������� "Item46" �� �������� �� "Item4".

            // ����'����� ���������� ���� �� ����
            label1.ContextMenuStrip = contextMenu; // ����'����� ���������� ���� �� label1.
            label2.ContextMenuStrip = contextMenu; // ����'����� ���������� ���� �� label2.
            label3.ContextMenuStrip = contextMenu; // ����'����� ���������� ���� �� label3.

            // ������ ������� ���� ��� ������� ������ ����
            item1.Click += (s, e) => MessageBox.Show("Item1 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item1".
            item21.Click += (s, e) => MessageBox.Show("Item21 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item21".
            item22.Click += (s, e) => MessageBox.Show("Item22 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item22".
            item23.Click += (s, e) => MessageBox.Show("Item23 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item23".

            item31.Click += (s, e) => MessageBox.Show("Item31 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item31".
            item32.Click += (s, e) => MessageBox.Show("Item32 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item32".
            item33.Click += (s, e) => MessageBox.Show("Item33 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item33".

            item41.Click += (s, e) => MessageBox.Show("Item41 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item41".
            item42.Click += (s, e) => MessageBox.Show("Item42 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item42".
            item43.Click += (s, e) => MessageBox.Show("Item43 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item43".
            item44.Click += (s, e) => MessageBox.Show("Item44 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item44".
            item45.Click += (s, e) => MessageBox.Show("Item45 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item45".
            item46.Click += (s, e) => MessageBox.Show("Item46 clicked"); // ������ �������� ��䳿 ��� ���������� �� "Item46".
        }
    }
}
