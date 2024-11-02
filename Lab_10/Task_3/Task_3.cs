using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_3 : Form
    {
      
        public Task_3()
        {
            InitializeComponent(); 
        }

        // Обробник натискання кнопки вибору папки
        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            // Виклик діалогу вибору папки
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK) // Перевірка на успішний вибір
                {
                    LoadImagesFromFolder(folderDialog.SelectedPath); // Завантаження зображень
                }
            }
        }

        // Завантаження зображень з вибраної папки
        private void LoadImagesFromFolder(string folderPath)
        {
            // Очищення попередніх зображень
            listBoxImages.Items.Clear(); // Очищення ListBox
            pictureBoxPreview.Image = null; // Скидання PictureBox

            // Отримання файлів зображень з папки
            var imageFiles = Directory.GetFiles(folderPath) // Отримання всіх файлів
                                      .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || // Формати зображень
                                                     file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".tif", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".webp", StringComparison.OrdinalIgnoreCase)) 
                                      .ToArray();

            // Додавання зображень до ListBox
            foreach (var file in imageFiles)
            {
                listBoxImages.Items.Add(file); // Додавання файлів у список
            }
        }

        // Обробник зміни вибору в списку зображень
        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Відображення вибраного зображення
            if (listBoxImages.SelectedItem != null) // Перевірка на вибір
            {
                var selectedImagePath = listBoxImages.SelectedItem.ToString(); // Отримання шляху
                pictureBoxPreview.Image = Image.FromFile(selectedImagePath); // Завантаження зображення в PictureBox
            }
        }
    }
}
