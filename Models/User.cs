using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_Management_System.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string AccessToken { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}