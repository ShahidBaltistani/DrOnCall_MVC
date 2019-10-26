//using DoctorOnCall.Model.Patients;
//using DoctorOnCall.ViewModel.Patient;
//using DoctorOnCall.Web.ModelHelpers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace DoctorOnCall.Web.Areas.Administration.Controllers
//{
//    public class AdminUserController : Controller
//    {

//        private OnlineConsultationService consultationService;
//        private UserService userService;


//        public AdminUserController()
//        {
//            consultationService = new OnlineConsultationService();
//           userService = new UserService();

//        }

//        // GET: Patient
//        public ActionResult UserLogin()
//        {
//            return View();
//        }
//        public ActionResult UserSignUp()
//        {
//            return View();
//        }
//        [HttpPost]
//        public ActionResult UserSignUp(UserViewModel model)
//        {
//            if (ModelState != null)
//            {
//                userService.CreateUser(model);
//            }
//            return RedirectToAction("ListOfUsers");
           
//        }


//        [HttpGet]
//        public ActionResult ListOfUsers()
//        {
//            //loggedin user id
//            var data = userService.GetAll();
//            return View(data);
//        }
//        public ActionResult AppointmentDetails()
//        {
//            //loggedin user id

//            var data = consultationService.GetAll();


//            return View();
//        }
//    }
//}