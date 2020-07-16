using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationExample.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public String AddressOne { get; set; }
        public String State { get; set; }
        public int Pincode { get; set; }
        public int EmployeeId { get; set; }


        public virtual Employee Employee { get; set; }
    }
}