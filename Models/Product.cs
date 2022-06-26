using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string desc { get; set; }
        public string price { get; set; }
        //public virtual User Seller { get; set; }
        //public int SellerId { get; set; }
        public int quantity { get; set; }
    }
}