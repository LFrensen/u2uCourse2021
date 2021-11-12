using System;

namespace ProductsLab
{
    public class Product
    {
        public Brand Brand { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        private decimal unitPrice;

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set 
            { 
                if(value > 0)
                {
                    unitPrice = value;
                } else
                {
                    Console.WriteLine($"ERROR: cannot assign a negative value to the unit price ({value})");
                }
            }
        }

        private int unitsInStock;

        public int UnitsInStock
        {
            get { return unitsInStock; }
            set
            {
                if (value >= 0)
                {
                    unitsInStock = value;
                }
                else
                {
                    Console.WriteLine($"ERROR: cannot assign a negative value to the units in stock ({value})");
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Product name: {ProductName}\nDescription: {Description}\n" +
                              $"Unit price: {UnitPrice} and there are {UnitsInStock} units left " +
                              $"of brand {Brand.BrandName}\n");
        }

        public decimal GetDiscount(int percentage)
        {
            if(percentage > 0 && percentage < 100)
            {
                return UnitPrice -= (UnitPrice * percentage) / 100;
            }
            return UnitPrice;
        } 

        public void ChangeValues(string productName)
        {
            ProductName = productName;
        }
        public void ChangeValues(decimal unitPrice)
        {
            UnitPrice = unitPrice;
        }
        public void ChangeValues(string productName, decimal unitPrice)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
        }
        public void ChangeValues(string productName, string description)
        {
            ProductName = productName;
            Description = description;
        }
    }
}
