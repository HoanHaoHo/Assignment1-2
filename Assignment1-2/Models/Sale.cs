using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1_2.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        public virtual ICollection<Product> Prodcuts { get; set; }
       
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public string EmployeeApprove { get; set; }
        public virtual Employee EmployeeApp { get; set; }
    }
}