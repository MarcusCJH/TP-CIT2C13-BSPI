using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCMSystem.classes
{
    class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double CurrentPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsToOrder { get; set; }
        public int ReorderLevel { get; set; }


    }
}
