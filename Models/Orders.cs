using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public virtual User Buyer { get; set; }
        public int BuyerId { get; set; }
        public int NoOfProducts { get; set; }


    }
}