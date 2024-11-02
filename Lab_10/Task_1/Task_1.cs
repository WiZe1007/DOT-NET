using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_1 : Form
    {
        private string[] imageFiles; // ����� ���������
        private int currentIndex = 0; // ������ ����������

        public Task_1()
        {
            InitializeComponent(); // �����������
        }

        // ���� �����
        private void buttonFolder_Click()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                // ĳ���� ������ �����
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath; // ������ �����
                    // ��������� ���������
                    imageFiles = Directory.GetFiles(selectedPath, "*.*")
                        .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".tif", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    // �������� �������� ���������
                    if (imageFiles.Length > 0)
                    {
                        currentIndex = 0; // ��������
                        LoadImage(); // ������������
                    }
                    else
                    {
                        MessageBox.Show("No images found."); // ³�������� ���������
                    }
                }
            }
        }

        // �������� ����������
        private void buttonNext_Click()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Length; // ���� �������
                LoadImage(); // ������������
            }
        }

        // �������� ����������
        private void buttonPrevious_Click()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Length) % imageFiles.Length; // ���� �������
                LoadImage(); // ������������
            }
        }

        // ������������ ����������
        private void LoadImage()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]); // ³����������
            }
        }
    }
}
