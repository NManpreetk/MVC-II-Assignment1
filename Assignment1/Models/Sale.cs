using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Sale()
        {
            Users = new HashSet<ApplicationUser>();
            Products = new HashSet<Product>();
        }

        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}