using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCMSystem.classes
{
    class InvoiceItem
    {
        public string InvoiceID { get; set; }
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
