using System;
using System.Drawing; 
using System.Windows.Forms; 

namespace Task_003 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent(); 
        }

        private void buttonSend_Click(object sender, EventArgs e) // ������� ���� �� "³������"
        {
            // ������ ��� �������� �� ��������� ����
            var checkBoxes = new CheckBox[] { checkBoxSports, checkBoxTravel, checkBoxCrafting, checkBoxPainting };
            var labels = new Label[] { labelSports, labelTravel, labelCrafting, labelPainting };
            var selectedItems = ""; // ����� ��� ��������� �������� ��������

            // ���� ������ ��� �������� ��������
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    labels[i].Font = new Font(labels[i].Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    selectedItems += labels[i].Text + "\n"; // ��������� ��������� �������� �� ������
                }
            }

            // ³���������� �������� �������� � MessageBox
            if (string.IsNullOrEmpty(selectedItems))
            {
                MessageBox.Show("�� ������� ������� ��������.", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("������ ��������:\n" + selectedItems, "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) // ������� ���� �� "�������"
        {
            // ������ ��� �������� ������ �� ��������
            var labels = new Label[] { labelSports, labelTravel, labelCrafting, labelPainting };
            var checkBoxes = new CheckBox[] { checkBoxSports, checkBoxTravel, checkBoxCrafting, checkBoxPainting };

            // �������� ������ �� ������������
            foreach (var label in labels)
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }

            // �������� ��������
            checkBoxSports.Checked = true; // "�����"
            checkBoxTravel.Checked = false; // "��������"
            checkBoxCrafting.Checked = true; // "������������"
            checkBoxPainting.Checked = false; // "���������"
        }
    }
}
