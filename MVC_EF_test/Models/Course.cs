using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_EF_test.Models
{
    public class Course
    {
        public short Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ApplicationUser InstructorUser { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}