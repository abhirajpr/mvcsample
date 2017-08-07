using CodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstMVC.Data
{
    public class StudentDbContext : DbContext
    {


        public StudentDbContext() : base("name=CodeFirstDBEntities")
        {
        }

        public virtual DbSet<Student> Students { get; set; }



    }
}