using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCMSystem.classes
{
    class Invoice
    {
        public string InvoiceID { get; set; }
        public string InvoiceDate { get; set; }
        public string OrderID { get; set; }
        public string SellerID { get; set; }
        public double ItemsTotalPrice { get; set; }
        public double ShippingCharges { get; set; }
        public double InvoiceTotal { get; set; }


    }
}
