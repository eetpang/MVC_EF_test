using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_EF_test.Models;
using System.Data.Entity;

namespace MVC_EF_test.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Course page.";
            
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        public ActionResult Student()
        {
            var students = _context.Students.Include(a => a.Major).ToList();
            return View(students);
        }
    }
}