using DoctorOnCall.Repository;
using DoctorOnCall.Services;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Areas.Administration.Controllers
{
    public class AdminAppointmentController : Controller
    {
        private AppointmentCreateService _appointmentService;
        public AdminAppointmentController()
        {
            this._appointmentService = new AppointmentCreateService();
        }
        // GET: Appointment
        public ActionResult Appointments()
        {
            var appointments = _appointmentService.GetAllAppointments();
            return View(appointments);
        }
      
    }
}