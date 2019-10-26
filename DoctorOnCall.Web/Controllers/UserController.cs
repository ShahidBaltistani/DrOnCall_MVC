using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Repository;
using DoctorOnCall.Services;
using DoctorOnCall.ViewModel.Account;
using DoctorOnCall.ViewModel.Patients;
using PagedList;
using PagedList.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Controllers
{
    public class UserController : Controller
    {
        public static bool IsLoggedIn =false;

           private readonly OnlineConsultationService consultationService;
           private readonly SignUpService signUpService;
           private readonly AppointmentCreateService appointmentService;
        public UserController()
        {
            consultationService = new OnlineConsultationService();
            signUpService = new SignUpService();
            appointmentService = new AppointmentCreateService();

        }

        public ActionResult ListofUser(string search, int? page)
        {
            var db = new DoctorOnCallContext();

            var result = db.Patients.Where(x => x.Name.StartsWith(search) || search == null).ToString().ToPagedList(page ?? 1, 3);
            return View(result);
            //var listofUser = signUpService.GetAll();
            //return View(listofUser);
        }
    
        [HttpPost]
        public ActionResult UserLogin(SignUpViewModel model)
        {
            var db = new DoctorOnCallContext();

            if ( model.Email == "Shahid@gmail.com" && model.Password == "1234")
            {
                return RedirectToAction("UserDashBoard");
            }
            else 
            {
                return RedirectToAction("DoctorDashBoard", "Doctor");
            }
        }
        public ActionResult UserDashBoard(int ? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 5;
            var appointments = appointmentService.GetAllAppointments().ToPagedList(pageNumber, pageSize);
            return View(appointments);
        }
        public ActionResult UserDetails(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 5;
            var appointments = appointmentService.GetAllAppointments().ToPagedList(pageNumber, pageSize);
            return View(appointments);
        }
        public ActionResult UserSignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserSignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                signUpService.AddUser(model);
            }

           return View();
            
        }
       
        //public ActionResult Index(string search)
        //{
        //    var db = new DoctorOnCallContext();
        //    //if (searchBy == "Name")
        //    //{
        //    //    return View(db.Patients.Where(x => x.Gender == search || search == null).ToList());
        //    //}
        //    //else
        //    //{
        //    //    return View(db.Patients.Where(x => x.Name.StartsWith(search)  || search == null).ToString());
        //    //}
        //    var result = db.Patients.Where(x => x.Name.StartsWith(search) || search == null).ToString();
        //     return View(result);

        //}

    }
}