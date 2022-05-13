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
        public virtual OrderStatus OrderStatus { get; set; }
        public int OrderStatusId { get; set; }
        public virtual User Buyer { get; set; }
        public int BuyerId { get; set; }
        public virtual Items Items { get; set; }
        public int ItemsId { get; set; }

    }
}