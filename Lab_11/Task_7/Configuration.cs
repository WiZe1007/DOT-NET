using System;
using System.Drawing;

namespace Lab_11_Task_7
{
    [Serializable]
    public class Configuration
    {
        // Параметри для labelTitle
        public int LabelTitleForeColorArgb { get; set; }
        public string LabelTitleFontName { get; set; }
        public float LabelTitleFontSize { get; set; }
        public FontStyle LabelTitleFontStyle { get; set; }

        // Параметри для groupBoxContactInfo
        public int GroupBoxContactInfoForeColorArgb { get; set; }
        public string GroupBoxContactInfoFontName { get; set; }
        public float GroupBoxContactInfoFontSize { get; set; }
        public FontStyle GroupBoxContactInfoFontStyle { get; set; }

        // Параметри для groupBoxPersonalInfo
        public int GroupBoxPersonalInfoForeColorArgb { get; set; }
        public string GroupBoxPersonalInfoFontName { get; set; }
        public float GroupBoxPersonalInfoFontSize { get; set; }
        public FontStyle GroupBoxPersonalInfoFontStyle { get; set; }

        // Параметри для groupBoxEvaluation
        public int GroupBoxEvaluationForeColorArgb { get; set; }
        public string GroupBoxEvaluationFontName { get; set; }
        public float GroupBoxEvaluationFontSize { get; set; }
        public FontStyle GroupBoxEvaluationFontStyle { get; set; }

        // Параметри для buttonSubmit
        public int ButtonSubmitForeColorArgb { get; set; }
        public string ButtonSubmitFontName { get; set; }
        public float ButtonSubmitFontSize { get; set; }
        public FontStyle ButtonSubmitFontStyle { get; set; }
    }
}
