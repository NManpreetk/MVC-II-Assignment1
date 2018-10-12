using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public Employee()
        {
            Users = new HashSet<ApplicationUser>();
            Sales = new HashSet<Sale>();
        }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}