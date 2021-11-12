using System;

namespace ProductsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ProductsLab console application!");

            Brand sony = new Brand();
            sony.BrandName = "Sony";
            sony.Industry = "Gaming";

            Brand dell = new Brand();
            dell.BrandName = "Dell";
            dell.Industry = "Hardware";

            Console.WriteLine($"Brand name: {sony.BrandName} - Industry: {sony.Industry}.\n");
            Console.WriteLine($"Brand name: {dell.BrandName} - Industry: {dell.Industry}.\n");

            Product laptop = new Product();
            laptop.ProductName = "Laptop";
            laptop.Description = "XPS SSD 16 Gb. RAM.";
            laptop.UnitPrice = 1000;
            laptop.UnitsInStock = 41;

            Product ps4 = new Product();
            ps4.ProductName = "PlayStation 4";
            ps4.Description = "Next generation game computer";
            ps4.UnitPrice = 399;
            ps4.UnitsInStock = 0;

            ps4.Brand = sony;
            laptop.Brand = dell;

            laptop.PrintInfo();
            ps4.PrintInfo();

            laptop.GetDiscount(25);
            laptop.PrintInfo();

            laptop.ChangeValues(1200);
            laptop.ChangeValues("LAPTOP");
            laptop.PrintInfo();

            ps4.ChangeValues("PLAYSTATION 4", 1000000000000000);
            laptop.ChangeValues("Lap Toppie", 999);
            ps4.PrintInfo();
            laptop.PrintInfo();
        }
    }
}
