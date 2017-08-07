using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstMVC.Models
{
    public class Student
    {

        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
       
        public string Email { set; get; }

        public int Age { set; get; }

    }
}