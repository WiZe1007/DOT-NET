using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_11_Task_5
{
    public partial class MainForm : Form
    {
        // Список міст
        private List<City> cities;

        public MainForm()
        {
            InitializeComponent();
            InitializeCities();
            PopulateComboBox();
        }

        private void InitializeCities()
        {
            // Перетворюємо масиви байтів у зображення
            Image cairoImage = ByteArrayToImage(Properties.Resources.cairo);
            Image alexandriaImage = ByteArrayToImage(Properties.Resources.alexandria);
            Image luxorImage = ByteArrayToImage(Properties.Resources.luxor);
            Image hurghadaImage = ByteArrayToImage(Properties.Resources.hurghada);
            Image sharmImage = ByteArrayToImage(Properties.Resources.sharm);

            // Створюємо об'єкти міст
            cities = new List<City>
            {
            new City("Каїр", "Столиця Єгипту, найбільше місто Африки.", cairoImage),
            new City("Александрія", "Відоме портове місто на Середземному морі.", alexandriaImage),
            new City("Луксор", "Місто-музей під відкритим небом з древніми храмами.", luxorImage),
            new City("Хургада", "Популярний курорт на Червоному морі.", hurghadaImage),
            new City("Шарм-ель-Шейх", "Відомий курорт з чудовими місцями для дайвінгу.", sharmImage)
            };
        }

        // Метод для перетворення масиву байтів у зображення
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void PopulateComboBox()
        {
            foreach (var city in cities)
            {
                comboBoxCities.Items.Add(city.Name);
            }
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxCities.SelectedIndex;
            if (selectedIndex >= 0)
            {
                City selectedCity = cities[selectedIndex];
                InfoForm form2 = new InfoForm(selectedCity);
                form2.ShowDialog();
            }
        }
    }
}
