using CodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstMVC.Data;

namespace CodeFirstMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        public ActionResult create1()
        {
            return View();
        }

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult CreateUser()
        //{
        //    StudentDbContext db = new StudentDbContext();
        //    Student st = new Student();
        //    UpdateModel(st);
        //    db.Students.Add(st);
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}
        public ActionResult create1(Student obj)
        {
            StudentDbContext db = new StudentDbContext();
            db.Students.Add(obj);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        public ActionResult Index()
        {
            StudentDbContext dbContext = new StudentDbContext();
            List<Student> employess = dbContext.Students.ToList();
            return View(employess);
            
        }


        public ActionResult edit(int Id)
        {
            StudentDbContext dbContext = new StudentDbContext();
            Student employee = dbContext.Students.Where(c => c.ID == Id).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]

        public ActionResult edit(Student emp)
        {
            StudentDbContext dbContext = new StudentDbContext();
            Student employee = dbContext.Students.Where(c => c.ID == emp.ID).FirstOrDefault();
            //employee.Name = emp.Name;
            //employee.Email = emp.Email;
            //employee.Phone = emp.Phone;
            dbContext.Entry(employee).CurrentValues.SetValues(emp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult delete(int Id)
        {

            StudentDbContext dbContext = new StudentDbContext();
            Student employee = dbContext.Students.Where(c => c.ID == Id).FirstOrDefault();
            dbContext.Students.Remove(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult details(int id)
        {
            //StudentDbContext dbContext = new StudentDbContext();
            //Student employee = dbContext.Students.Where(c => c.ID == id).FirstOrDefault();

            return View();
        }


        public ActionResult getEmployee()
        {
            return View();
        }

        public ActionResult PartialEmployee()
        {

            StudentDbContext dbContext = new StudentDbContext();
            List<Student> employess = dbContext.Students.ToList();
            return PartialView("PartialEmployee",employess);
        }
    }


}