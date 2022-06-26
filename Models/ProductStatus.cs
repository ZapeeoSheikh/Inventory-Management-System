using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class ProductStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int ItemsId { get; set; }

    }
}