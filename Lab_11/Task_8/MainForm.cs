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

        // �������� ����� ����
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFilePath = string.Empty;
        }

        // ³������ ����
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "������� ����� (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|�� ����� (*.*)|*.*";
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

        // �������� ����
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

        // �������� ��
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "������� ����� (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|�� ����� (*.*)|*.*";
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

        // ³���������� ������� �������
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(index);
            int column = index - richTextBox1.GetFirstCharIndexOfCurrentLine();
            toolStripStatusLabel1.Text = $"�����: {line + 1}, ��������: {column + 1}";
        }

        // �������� "��� ��������"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        // ������� ����� �� �����
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
                return "����";

            if (number < 0)
                return "���� " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " ������ ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " ����� ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " ��� ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "";

                var unitsMap = new[]
                {
                    "", "����", "���", "���", "������", "�'���",
                    "�����", "��", "���", "���'���", "������", "����������",
                    "����������", "����������", "������������", "�'���������",
                    "�����������", "���������", "����������", "���'���������"
                };

                var tensMap = new[]
                {
                    "", "������", "��������", "��������", "�����", "�'�������",
                    "���������", "�������", "��������", "���'������"
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
