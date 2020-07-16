using CodeFirstMigrationExample.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationExample.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
           // var Employees = new List<Employee>
           // {
           // new Employee{Name="Carson",PhoneNumber="9515851499"},
           //new Employee{Name="Carson",PhoneNumber="9515851499"}
           // };
           // Employees.ForEach(e =>context.Employees.Add(e));
           // context.SaveChanges();
           // var Addresses = new List<Address>
           // {
           //     new Address{ AddressOne = "chennai", State = "Tn", Pincode = 600125, EmployeeId = 1},
           //     new Address{ AddressOne = "Salem", State = "Tn", Pincode = 600126, EmployeeId = 2}
           // };
           // Addresses.ForEach(a => context.Addresses.Add(a));
           // context.SaveChanges();
        }
    }
}