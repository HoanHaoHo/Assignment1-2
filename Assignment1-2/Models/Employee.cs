using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment1_2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        [InverseProperty("Employee")]
        public ICollection<Sale> Sales { get; set; }
        public Employee()
        {
            Sales = new HashSet<Sale>();
        }
    }
}