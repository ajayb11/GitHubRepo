using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitDotNet.Models
{
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        [Required]
        public string employeeName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int experience { get; set; }
    }
}
