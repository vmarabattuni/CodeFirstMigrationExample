using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationExample.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}