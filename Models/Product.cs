using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thi_wcd.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }

        public virtual Category Category { get; set; }
    }
}