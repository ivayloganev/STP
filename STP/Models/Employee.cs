using System;
using STP.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace STP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartingDate { get; set; }
        public decimal Salary { get; set; }
        public int VacationDays { get; set; }
        public Experience Experience { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
    }
}
