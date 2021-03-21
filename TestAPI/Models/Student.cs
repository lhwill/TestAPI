using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }
        public int GId { get; set; }
        public string Phone { get; set; }
    }
}
