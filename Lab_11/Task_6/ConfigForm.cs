using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11_Task_6
{
    public partial class ConfigForm : Form
    {
        private MainForm mainForm;

        public ConfigForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void buttonColorLabelTitle_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.labelTitle.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFontLabelTitle_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.labelTitle.Font = fontDialog1.Font;
            }
        }

        private void buttonColorGroupBoxContactInfo_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBoxContactInfo.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFontGroupBoxContactInfo_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBoxContactInfo.Font = fontDialog1.Font;
            }
        }

        private void buttonColorGroupBoxPersonalInfo_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBoxPersonalInfo.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFontGroupBoxPersonalInfo_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBoxPersonalInfo.Font = fontDialog1.Font;
            }
        }

        private void buttonColorGroupBoxEvaluation_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBoxEvaluation.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFontGroupBoxEvaluation_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.groupBoxEvaluation.Font = fontDialog1.Font;
            }
        }

        private void buttonColorButtonSubmit_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.buttonSubmit.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFontButtonSubmit_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mainForm.buttonSubmit.Font = fontDialog1.Font;
            }
        }
    }
}
