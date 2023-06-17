using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantSalesApp
{
    public class Plant
    {
        private int plantID;
        private string name;
        private string type;
        private string size;
        private decimal price;
        private string description;
        private string colors;
        private decimal quantity;
        private string availability;
        private string dateAdded;
        private int userID;

        public Plant()
        {
        }

        public int PlantID
        {
            get { return plantID; }
            set { plantID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string PotColor
        {
            get { return colors; }
            set { colors = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
