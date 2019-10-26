//using DoctorOnCall.ViewModel;
//using DoctorOnCall.Web.ModelHelpers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;

//namespace DoctorOnCall.Web.Areas.Administration.Controllers

//{
//    public class AdminOnlineConsultationController : Controller
//    {
//        OnlineConsultationService onlineConsultationService = new OnlineConsultationService();
//        // GET: OnlineConsultation
//        public ActionResult Index()
//        {
//          var data=  onlineConsultationService.GetAll();
//            return View(data);
//        }


//        [HttpGet]
//        public ActionResult Delete(int id)
//        {
//            var data = new OnlineConsultationService();
//            data.Delete(id);
//            return View();
//        }
//        public ActionResult Edit(int id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//                var data = onlineConsultationService.GetById(id);
//            if (data == null)
//            {
//                return HttpNotFound();
//            }
//            return View(data);
            
//        }
//        public ActionResult GetById(int id)
//        {
//            var data = new OnlineConsultationService();
//            data.GetById(id);
//            return View();
//        }

//    }
//}