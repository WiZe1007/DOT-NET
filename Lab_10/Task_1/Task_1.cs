using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_1 : Form
    {
        private string[] imageFiles; // Файли зображень
        private int currentIndex = 0; // Індекс зображення

        public Task_1()
        {
            InitializeComponent(); // Ініціалізація
        }

        // Вибір папки
        private void buttonFolder_Click()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                // Діалог вибору папки
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath; // Обрана папка
                    // Отримання зображень
                    imageFiles = Directory.GetFiles(selectedPath, "*.*")
                        .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".tif", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    // Перевірка наявності зображень
                    if (imageFiles.Length > 0)
                    {
                        currentIndex = 0; // Скидання
                        LoadImage(); // Завантаження
                    }
                    else
                    {
                        MessageBox.Show("No images found."); // Відсутність зображень
                    }
                }
            }
        }

        // Наступне зображення
        private void buttonNext_Click()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Length; // Зміна індексу
                LoadImage(); // Завантаження
            }
        }

        // Попереднє зображення
        private void buttonPrevious_Click()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Length) % imageFiles.Length; // Зміна індексу
                LoadImage(); // Завантаження
            }
        }

        // Завантаження зображення
        private void LoadImage()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]); // Відображення
            }
        }
    }
}
