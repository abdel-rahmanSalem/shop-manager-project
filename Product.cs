using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopManager
{
    internal class Product
    {
        private string name;
        private string category;
        public int Quantity, ID;
        private double[] price = new double[2];
        private double totalPrice;

        public Product(string name, string category, int quantity, int iD, double cost, double profit)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ID = iD;
            Cost = cost;
            Profit = profit;
        }
        public string Name
        {
            get
            { return name; }
            set
            {
                if (value != "")
                    name = value;
            }
        }
        public string Category
        {
            get
            { return category; }
            set
            {
                if (value != "")
                    category = value;
            }
        }
        public double Cost
        {
            get { return price[0]; }
            set
            {
                if (value > 0)
                    price[0] = value;
            }
        }
        public double Profit
        {
            get { return price[1]; }
            set
            {
                if (value >= 0)
                    price[1] = value;
            }
        }
        public double TotalPrice()
        {
            totalPrice = Cost + Profit;
            return totalPrice;
        }
    }
}

