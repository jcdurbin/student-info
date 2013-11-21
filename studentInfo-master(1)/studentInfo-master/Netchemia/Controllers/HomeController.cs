using Netchemia.Model;
using Netchemia.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Netchemia.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View("/Views/Index.cshtml");
        }

        public ActionResult GetStudentInfo()
        {
            IList<Student> students = new List<Student>()
            {
                new Student(){
                    FirstName = "Michael",
                    LastName = "Jordan",
                    Address = "Chicago, IL",
                    PhoneNumber = "555-555-2323",
                    StudentType = "doctorate"
                },
                new Student(){
                    FirstName = "Dirk",
                    LastName = "Nowitzki",
                    Address = "Dallas, TX",
                    PhoneNumber = "555-555-4141",
                    StudentType = "graduate"
                },
                new Student(){
                    FirstName = "Kobe",
                    LastName = "Bryant",
                    Address = "Los Angeles, CA",
                    PhoneNumber = "555-555-2408",
                    StudentType = "undergraduate"
                },
                new Student(){
                    FirstName = "Magic",
                    LastName = "Johnson",
                    Address = "Los Angeles, CA",
                    PhoneNumber = "555-555-3232",
                    StudentType = "graduate"
                }
            };

            return View("~/Views/Shared/_StudentDetails.cshtml", students);
        }
        // - to be used with Netchemia.Data
        //public ActionResult StudentInfo(int? id)
        //{
        //    using (var context = new Context())
        //    {
        //        var model = new MainPage
        //        {
        //            Students = context.Students
        //                .Where(t => t.AreActive)
        //                .ToList()
        //        };

        //        return View(model);
        //    }
        //}

    }
}
