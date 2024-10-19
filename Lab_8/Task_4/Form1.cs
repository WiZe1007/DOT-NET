using System; 
using System.Windows.Forms; 

namespace Task_04 
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent(); 
        }

        private void ButtonSubmit_Click(object sender, EventArgs e) // �������� ���������� ������ "Submit"
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
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            DateTime visitDate = dateTimePickerVisit.Value;
            string age = comboBoxAge.SelectedItem?.ToString();
            string cuisine = comboBoxCuisine.SelectedItem?.ToString();
            string dishes = textBoxDishes.Text;

            // ���� ������� �� ������������
            string reason = radioButtonReason1.Checked ? radioButtonReason1.Text : radioButtonReason2.Text;
            string recommend = radioButtonYes.Checked ? "���" : "ͳ";

            // ���������� �����������
            string message = $"��'�: {name}\n�����: {email}\n�������: {phone}\n���� ����������: {visitDate.ToShortDateString()}\n" +
                             $"³�: {age}\n�������� �����: {cuisine}\n������: {dishes}\n���� ������ ��� ��������: {reason}\n" +
                             $"�� ������������� ��������: {recommend}";

            MessageBox.Show(message, "���������� ��� ���������"); // ��������� ����������
        }

        private void ButtonClear_Click(object sender, EventArgs e) // �������� ���������� ������ "Clear"
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
    }
}
