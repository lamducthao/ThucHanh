using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThucHanh.Controllers
{
    public class AsdController : Controller
    {
        // GET: Asd
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Demo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Demo(string Masinhvien, string Hoten)
        {
            ViewBag.message = Masinhvien + " " + Hoten;
            return View();
        }
    }
}