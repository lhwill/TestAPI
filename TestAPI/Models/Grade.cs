using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    public class Grade
    {
        [Key]
        public int GId { get; set; }
        public string GName { get; set; }
    }
}
