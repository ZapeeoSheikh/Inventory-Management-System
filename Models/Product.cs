using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public string desc { get; set; }
        public int price { get; set; }
        //public virtual User Seller { get; set; }
        //public int SellerId { get; set; }
        public double rating { get; set; }
        public int quantity { get; set; }
    }
}