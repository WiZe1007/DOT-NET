using System;
using System.Windows.Forms;
using System.Drawing;

namespace Task_02
{
    public partial class Form1 : Form
    {
        private Font originalFont; // ��������� ����. ������
        private RadioButton[] cityRadioButtons; // ����� ���������� ��� ���
        private RadioButton[] transportRadioButtons; // ����� ���������� ��� ����������

        public Form1()
        {
            InitializeComponent();
            // ������������ ���� �� �������������
            radioButtonKharkiv.Checked = true;
            radioButtonTrain.Checked = true;

            // ��������� ������������ ������
            originalFont = radioButtonKharkiv.Font;

            // ����������� ������ ����������
            cityRadioButtons = new[] { radioButtonKharkiv, radioButtonKyiv, radioButtonOdesa, radioButtonZaporizhzhia };
            transportRadioButtons = new[] { radioButtonBus, radioButtonTrain, radioButtonPlane };
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            // ��������� ��������� ���� �� ����������
            string selectedCity = GetSelectedRadioButtonText(cityRadioButtons);
            string selectedTransport = GetSelectedRadioButtonText(transportRadioButtons);
            MessageBox.Show($"�� ������� ����: {selectedCity} �� ���������: {selectedTransport}", "����");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // ���������� ������ �� ����������� �����
            radioButtonKharkiv.Checked = true;
            radioButtonTrain.Checked = true;

            // ³��������� ������������ ������ ��� ��� ����������
            ResetFonts(cityRadioButtons);
            ResetFonts(transportRadioButtons);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // ������� ����� ������ ��� �������� ����������
            SetBoldItalicUnderline(cityRadioButtons);
            SetBoldItalicUnderline(transportRadioButtons);
        }

        private string GetSelectedRadioButtonText(RadioButton[] radioButtons)
        {
            // ����������� ������ ������� ����������
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty; // ���� ����� �� �������
        }

        private void ResetFonts(RadioButton[] radioButtons)
        {
            // ³��������� ������������ ������ ��� ����������
            foreach (var radioButton in radioButtons)
            {
                radioButton.Font = originalFont;
            }
        }

        private void SetBoldItalicUnderline(RadioButton[] radioButtons)
        {
            // ������� ����� ������ ��� �������� ����������
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    radioButton.Font = new Font(originalFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
            }
        }
    }
}
