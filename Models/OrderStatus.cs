using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public virtual Orders Orders { get; set; }
        public int OrderId { get; set; }
    }
}