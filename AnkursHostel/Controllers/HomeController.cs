using AnkursHostel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnkursHostel.Controllers
{
    public class HomeController : Controller
    {
        AnkursHostelEntities1 db = new AnkursHostelEntities1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pricing()
        {
            return View();
        }

        public ActionResult Features()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Customer c)
        {
            if (ModelState.IsValid == true)
            {
                db.Customers.Add(c);
                int a = db.SaveChanges();
                if (a > 0)
                {

                    ViewBag.message = "<script>alert('Data Inserted.....')</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.message = "<script>alert('Data Not Inserted !!!!!!')</script>";
                }
            }

            return View();
        }
    }
}