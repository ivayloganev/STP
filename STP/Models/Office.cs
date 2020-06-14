using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STP.Models
{
    public class Office
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public bool IsHeadquarters { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
