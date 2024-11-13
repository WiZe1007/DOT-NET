using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_11_Task_8
{
    public partial class MainForm : Form
    {
        private string currentFilePath = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
        }

        // Створити новий файл
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFilePath = string.Empty;
        }

        // Відкрити файл
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстові файли (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|Усі файли (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = ofd.FileName;
                    if (Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                    {
                        richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
                    }
                }
            }
        }

        // Зберегти файл
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                SaveToFile(currentFilePath);
            }
            else
            {
                SaveAs();
            }
        }

        // Зберегти як
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстові файли (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|Усі файли (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = sfd.FileName;
                    SaveToFile(currentFilePath);
                }
            }
        }

        private void SaveToFile(string filePath)
        {
            if (Path.GetExtension(filePath).ToLower() == ".rtf")
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
        }

        // Відображення позиції курсора
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            int column = index - richTextBox1.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = $"Рядок: {line + 1}, Стовпець: {column + 1}";
        }

        // Показати "Про програму"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // Замінити числа на слова
        private void replaceNumbersWithWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string originalText = richTextBox1.Text;
            string newText = ReplaceNumbersWithWords(originalText);
            richTextBox1.Text = newText;
        }

        private string ReplaceNumbersWithWords(string input)
        {
            return Regex.Replace(input, @"\d+", new MatchEvaluator(NumberToWordsEvaluator));
        }

        private string NumberToWordsEvaluator(Match match)
        {
            if (int.TryParse(match.Value, out int number))
            {
                return NumberToWords(number);
            }
            return match.Value;
        }

        private string NumberToWords(int number)
        {
            if (number == 0)
                return "нуль";

            if (number < 0)
                return "мінус " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " мільйон ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " тисяч ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " сто ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "";

                var unitsMap = new[]
                {
                    "", "один", "два", "три", "чотири", "п'ять",
                    "шість", "сім", "вісім", "дев'ять", "десять", "одинадцять",
                    "дванадцять", "тринадцять", "чотирнадцять", "п'ятнадцять",
                    "шістнадцять", "сімнадцять", "вісімнадцять", "дев'ятнадцять"
                };

                var tensMap = new[]
                {
                    "", "десять", "двадцять", "тридцять", "сорок", "п'ятдесят",
                    "шістдесят", "сімдесят", "вісімдесят", "дев'яносто"
                };

                if (number < 20)
                {
                    words += unitsMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words.Trim();
        }
    }
}
