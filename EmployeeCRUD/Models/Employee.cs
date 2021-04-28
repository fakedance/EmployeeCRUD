using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string LastName { get; set; }


        [Column(TypeName = "nvarchar(10)")]
        public string Designation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Position { get; set; }
        public string Office { get; set; }
    }
}
