using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product()
        {
            Users = new HashSet<ApplicationUser>();
        }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}