using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace STP.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public ICollection<Office> Offices { get; set; }
    }
}
