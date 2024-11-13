using System.Drawing;

namespace Lab_11_Task_5
{
    public class City
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }

        public City(string name, string description, Image image)
        {
            Name = name;
            Description = description;
            Image = image;
        }
    }
}
