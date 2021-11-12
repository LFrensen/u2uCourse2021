using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebShop.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string VAT { get; set; } = "21%";
    }
}
