using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Controllers
{
    public class SearchForDoctorController : Controller
    {
        // GET: SearchForDoctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchDoctor()
        {
            return View();
        }
    }
}