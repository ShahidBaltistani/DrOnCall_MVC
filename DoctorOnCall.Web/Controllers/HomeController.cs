using DoctorOnCall.Repository;
using DoctorOnCall.Services;
using DoctorOnCall.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Controllers
{
    public class HomeController : Controller
    {
        HomeService homeService = new HomeService();
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult HomePage()
        {
          var dr=  homeService.GetAll().Take(4); //where(x->x.abc>10).Take(4);
            return View(dr);

        //    var patientReview = new PatientReviewRepository();
        //    //Saving for Search From Home
        //  SearchTitle.RecipeTitles = new SearchMappers().RecipeTemplateModelsToRecipeTitle(new DoctorCreateService().GetAll());
        //    ///////
        // ViewBag.PatientReviews = patientReview.GetAllPatientReviews();
        //    return View();
       }
    }
}