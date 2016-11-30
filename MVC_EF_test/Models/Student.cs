using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_EF_test.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser StudentUser { get; set; }

        [StringLength(255)]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public List<Course> CourseSelected { get; set; }

        [Required]
        public Major Major { get; set; }

        public byte MajorId { get; set; }

        public DateTime Birthdate { get; set; }

    }
}