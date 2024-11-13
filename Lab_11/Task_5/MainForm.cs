using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_11_Task_5
{
    public partial class MainForm : Form
    {
        // ������ ���
        private List<City> cities;

        public MainForm()
        {
            InitializeComponent();
            InitializeCities();
            PopulateComboBox();
        }

        private void InitializeCities()
        {
            // ������������ ������ ����� � ����������
            Image cairoImage = ByteArrayToImage(Properties.Resources.cairo);
            Image alexandriaImage = ByteArrayToImage(Properties.Resources.alexandria);
            Image luxorImage = ByteArrayToImage(Properties.Resources.luxor);
            Image hurghadaImage = ByteArrayToImage(Properties.Resources.hurghada);
            Image sharmImage = ByteArrayToImage(Properties.Resources.sharm);

            // ��������� ��'���� ���
            cities = new List<City>
            {
            new City("���", "������� ������, �������� ���� ������.", cairoImage),
            new City("����������", "³���� ������� ���� �� ������������ ���.", alexandriaImage),
            new City("������", "̳���-����� �� �������� ����� � ������� �������.", luxorImage),
            new City("�������", "���������� ������ �� ��������� ���.", hurghadaImage),
            new City("����-���-����", "³����� ������ � �������� ������ ��� �������.", sharmImage)
            };
        }

        // ����� ��� ������������ ������ ����� � ����������
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
