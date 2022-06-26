using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public virtual User Buyer { get; set; }
        public int BuyerId { get; set; }
        public virtual Orders Orders { get; set; }
        public int OrdersId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }

    }
}