using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u2uCourse2021
{
    public class Beer
    {
        public string Name { get; set; }
        public string Taste { get; set; }
        public double AlcoholPercentage { get; set; }

        public Beer(string name)
        {
            Name = name;
        }
        public Beer(string name, string taste): this(name)
        {
            Taste = taste;
        }
        public Beer(string name, string taste, double alcoholPercentage): this(name, taste)
        {
            AlcoholPercentage = Math.Max(alcoholPercentage, 0.1);
        }
    }
}
