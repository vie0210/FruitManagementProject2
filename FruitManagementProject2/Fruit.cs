using System;
using System.Collections.Generic;
using System.Text;

namespace FruitManagementProject2
{
    public class Fruit
    {

        // Encapsulation //
        
        // name
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // color
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        // shape
        private string shape;
        public string Shape
        {
            get { return shape; }
            set {  shape = value; }
        }
        // seed type
        private string seedType;
        public string SeedType
        {
            get { return seedType; }
            set {  seedType = value; }
        }
        // price
        private double price;
        public double Price
        {
            get { return price; }
            set {  price = value; }
        }
        // quantity
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set {  quantity = value; }
        }

        // Constructor
        public Fruit(string name, string color, string shape, string seed_type, double price, int quantity)
        {
            Name = name;
            Color = color;
            Shape = shape;
            SeedType = seed_type;
            Price = price;
            Quantity = quantity;
        }
    }
}
