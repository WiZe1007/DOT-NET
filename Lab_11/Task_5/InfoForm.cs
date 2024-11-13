using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lab_11_Task_5
{
    public partial class InfoForm : Form
    {
        private City city;

        public InfoForm(City selectedCity)
        {
            InitializeComponent();
            city = selectedCity;
            DisplayCityInfo();
        }

        private void DisplayCityInfo()
        {
            labelCityName.Text = city.Name;
            pictureBoxCity.Image = city.Image;
            textBoxDescription.Text = city.Description;
        }
    }
}
