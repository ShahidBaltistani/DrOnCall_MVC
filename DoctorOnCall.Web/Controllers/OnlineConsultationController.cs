using DoctorOnCall.Services;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.OnlineConsultations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Controllers
{
    public class OnlineConsultationController : Controller
    {
        OnlineConsultationService onlineConsultationService = new OnlineConsultationService();
        // GET: OnlineConsultation
        public ActionResult Index()
        {
            var data = onlineConsultationService.GetAll();
            return View(data);
        }
        public ActionResult CreateOnlineConsultation()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateOnlineConsultation(OnlineConsultationViewModel consultation)
        {
            if (consultation != null)
            {
                var data = new OnlineConsultationService();
                data.Add(consultation);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    var data = new OnlineConsultationService();
        //    data.Delete(id);
        //    return View();
        //}
        //public ActionResult Edit(OnlineConsultationViewModel model)
        //{
        //    var data = new OnlineConsultationService();
        //    data.Update(model);
        //    return View();
        //}
        public ActionResult GetById(int id)
        {
            var data = new OnlineConsultationService();
            data.GetById(id);
            return View();
        }

    }
}