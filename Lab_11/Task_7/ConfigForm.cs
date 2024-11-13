using Lab_11_Task_7;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11_Task_7
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

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            // Створення об'єкта конфігурації
            Configuration config = new Configuration();

            // Збір параметрів з головної форми
            SetFontAndColorConfig(config, mainForm.labelTitle, "LabelTitle");
            SetFontAndColorConfig(config, mainForm.groupBoxContactInfo, "GroupBoxContactInfo");
            SetFontAndColorConfig(config, mainForm.groupBoxPersonalInfo, "GroupBoxPersonalInfo");
            SetFontAndColorConfig(config, mainForm.groupBoxEvaluation, "GroupBoxEvaluation");
            SetFontAndColorConfig(config, mainForm.buttonSubmit, "ButtonSubmit");

            // Виклик SaveFileDialog
            saveFileDialog1.Filter = "Config Files|*.cfg|All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveConfigToFile(saveFileDialog1.FileName, config);
            }

            // Збереження у файл за замовчуванням
            string defaultConfigFile = Path.Combine(Application.StartupPath, "default.cfg");
            SaveConfigToFile(defaultConfigFile, config);
        }

        private void SetFontAndColorConfig(Configuration config, Control control, string prefix)
        {
            var font = control.Font;
            typeof(Configuration).GetProperty($"{prefix}ForeColorArgb")?.SetValue(config, control.ForeColor.ToArgb());
            typeof(Configuration).GetProperty($"{prefix}FontName")?.SetValue(config, font.FontFamily.Name);
            typeof(Configuration).GetProperty($"{prefix}FontSize")?.SetValue(config, font.Size);
            typeof(Configuration).GetProperty($"{prefix}FontStyle")?.SetValue(config, font.Style);
        }

        private void SaveConfigToFile(string fileName, Configuration config)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    string json = JsonConvert.SerializeObject(config);
                    writer.Write(json);
                }
                MessageBox.Show("Конфігурація успішно збережена.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні конфігурації: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Config Files|*.cfg|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string json = reader.ReadToEnd();
                        Configuration config = JsonConvert.DeserializeObject<Configuration>(json);

                        // Масив з елементами для налаштування і відповідними параметрами конфігурації
                        var elements = new (Control control, string fontName, float fontSize, FontStyle fontStyle, int colorArgb)[]
                        {
                    (mainForm.labelTitle, config.LabelTitleFontName, config.LabelTitleFontSize, config.LabelTitleFontStyle, config.LabelTitleForeColorArgb),
                    (mainForm.groupBoxContactInfo, config.GroupBoxContactInfoFontName, config.GroupBoxContactInfoFontSize, config.GroupBoxContactInfoFontStyle, config.GroupBoxContactInfoForeColorArgb),
                    (mainForm.groupBoxPersonalInfo, config.GroupBoxPersonalInfoFontName, config.GroupBoxPersonalInfoFontSize, config.GroupBoxPersonalInfoFontStyle, config.GroupBoxPersonalInfoForeColorArgb),
                    (mainForm.groupBoxEvaluation, config.GroupBoxEvaluationFontName, config.GroupBoxEvaluationFontSize, config.GroupBoxEvaluationFontStyle, config.GroupBoxEvaluationForeColorArgb),
                    (mainForm.buttonSubmit, config.ButtonSubmitFontName, config.ButtonSubmitFontSize, config.ButtonSubmitFontStyle, config.ButtonSubmitForeColorArgb)
                        };

                        // Застосування конфігурації до елементів форми
                        foreach (var (control, fontName, fontSize, fontStyle, colorArgb) in elements)
                        {
                            control.ForeColor = Color.FromArgb(colorArgb);
                            control.Font = new Font(fontName, fontSize, fontStyle);
                        }

                        MessageBox.Show("Конфігурація успішно завантажена.", "Завантаження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні конфігурації: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
