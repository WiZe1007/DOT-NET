using System;
using System.Windows.Forms;

namespace Lab_11_Task_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // �������� ���������� ������ Submit
        {
            // �������� �� ����������� ����
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                comboBoxAge.SelectedIndex == -1 ||
                comboBoxCuisine.SelectedIndex == -1 ||
                (!radioButtonReason1.Checked && !radioButtonReason2.Checked) ||
                (!radioButtonYes.Checked && !radioButtonNo.Checked))
            {
                MessageBox.Show("���� �����, �������� �� ����'����� ����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // ����������
            }

            // ��� �����
            var message = string.Join("\n", new[]
            {
                $"��'�: {textBoxName.Text}",
                $"�����: {textBoxEmail.Text}",
                $"�������: {textBoxPhone.Text}",
                $"���� ����������: {dateTimePickerVisit.Value.ToShortDateString()}",
                $"³�: {comboBoxAge.SelectedItem}",
                $"�������� �����: {comboBoxCuisine.SelectedItem}",
                $"������: {textBoxDishes.Text}",
                $"���� ������ ��� ��������: {(radioButtonReason1.Checked ? radioButtonReason1.Text : radioButtonReason2.Text)}",
                $"�� ������������� ��������: {(radioButtonYes.Checked ? "���" : "ͳ")}"
            });

            // ��������� �����������
            MessageBox.Show(message, "���������� ��� ���������");
        }

        private void ButtonClear_Click(object sender, EventArgs e) // �������� ���������� ������ Clear
        {
            // �������� ����
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            dateTimePickerVisit.Value = DateTime.Now;
            comboBoxAge.SelectedIndex = -1;
            comboBoxCuisine.SelectedIndex = -1;
            textBoxDishes.Clear();

            // �������� ����-������
            radioButtonReason1.Checked = false;
            radioButtonReason2.Checked = false;
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            // ³������� ����� �����������
            ConfigForm configForm = new ConfigForm(this);
            configForm.Show();
        }
    }
}
