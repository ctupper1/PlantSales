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
        private int careDifficulty;
        private string careDetails;
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
        public string Type
        {
            get { return type; }
            set { type = value; }
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
        public string Colors
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
        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }
        public string DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }
        public int CareDifficulty
        {
            get { return careDifficulty; }
            set { careDifficulty = value; }
        }
        public string CareDetails
        {
            get { return careDetails; }
            set { careDetails = value; }
        }
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
