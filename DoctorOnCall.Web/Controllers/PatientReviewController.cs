using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Controllers
{
    public class PatientReviewController : Controller
    {
        // GET: PatientReview
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateReview()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateReview(ViewModel.PatientReviews.PatientReviewViewModel model)
        {
            return View();
        }
    }
}