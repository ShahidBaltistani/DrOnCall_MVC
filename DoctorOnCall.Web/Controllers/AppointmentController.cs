using DoctorOnCall.Repository;
using DoctorOnCall.Services;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Controllers
{
    public class AppointmentController : Controller
    {
        private AppointmentCreateService appointmentService;
        public AppointmentController()
        {
            appointmentService = new AppointmentCreateService();
        }
        // GET: Appointment
        public ActionResult Index()
        {
            var appointments = appointmentService.GetAllAppointments();
            return View("./Shared/User/UserDashBoard.cshtml");
        }

        //public ActionResult CreateAppointment(AppointmentViewModel model)
        //{
        //    appointmentService.AddAppointment(model);
        //    return RedirectToAction("Index");
        //}


        public ActionResult CreateAppointment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAppointment(AppointmentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                appointmentService.AddAppointment(model);
                return RedirectToAction("Index");
            }
            return View();
           
        }
    }
}