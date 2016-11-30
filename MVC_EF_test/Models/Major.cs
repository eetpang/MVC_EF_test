using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_EF_test.Models
{
    public class Major
    {
        public byte Id { get; set; }

        [Display(Name = "Major")]
        public string Name { get; set; }
        
    }
}