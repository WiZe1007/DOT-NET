using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Task_2 : Form
    {
        private string[] imageFiles = Array.Empty<string>(); // Зображення
        private int currentIndex = 0; // Поточний індекс
        private bool isSlideshowRunning = false; // Статус слайд-шоу

        public Task_2()
        {
            InitializeComponent();
            timer.Interval = 1000; // 1 секунда
            timer.Tick += ShowNextImage; // Обробник зміни зображення
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    // Отримання зображень з папки
                    imageFiles = Directory.GetFiles(selectedPath, "*.*")
                        .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".tif", StringComparison.OrdinalIgnoreCase) ||
                                       file.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    if (imageFiles.Length > 0)
                    {
                        currentIndex = 0; // Скидання індексу
                        LoadImage(); // Завантаження зображення
                    }
                    else
                    {
                        MessageBox.Show("No images found."); // Повідомлення про відсутність зображень
                    }
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ShowNextImage(sender, e); // Наступне зображення
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (imageFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Length) % imageFiles.Length; // Попереднє зображення
                LoadImage(); // Завантаження зображення
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            isSlideshowRunning = !isSlideshowRunning; // Перемикач

            if (isSlideshowRunning)
            {
                buttonStartStop.Text = "Зупинити"; // Текст кнопки
                timer.Start(); // Запуск
            }
            else
            {
                buttonStartStop.Text = "Почати"; // Текст кнопки
                timer.Stop(); // Зупинка
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            textBoxSpeed.Text = trackBarSpeed.Value.ToString(); // Оновлення TextBox
            timer.Interval = trackBarSpeed.Value; // Інтервал таймера
        }

        private void textBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            // Перетворення тексту на число
            if (int.TryParse(textBoxSpeed.Text, out int newInterval) && newInterval > 0 && newInterval <= 10000)
            {
                timer.Interval = newInterval; // Інтервал
                trackBarSpeed.Value = newInterval; // Синхронізація
            }
            else
            {
                MessageBox.Show("Введіть число між 1 і 10000."); // Повідомлення про помилку
            }
        }

        private void ShowNextImage(object sender, EventArgs e)
        {
            if (imageFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Length; // Наступний індекс
                LoadImage(); // Завантаження зображення
            }
        }

        private void LoadImage()
        {
            pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]); // Завантаження в PictureBox
        }
    }
}
