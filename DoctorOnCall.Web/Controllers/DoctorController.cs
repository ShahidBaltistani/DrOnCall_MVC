using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.Services;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Appointments;
using DoctorOnCall.ViewModel.Doctors;
using DoctorOnCall.ViewModel.PatientReviews;
using PagedList;
using PagedList.Mvc;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DoctorOnCall.Web.Controllers
{

    public class DoctorController : Controller
    {
        Collection
        private readonly  DoctorCreateService _doctorCreateService;
        private readonly DoctorProfileService _doctorProfileService;
        private readonly AppointmentCreateService _appointmentCreateService;
        public DoctorController()
        {
            this._doctorCreateService = new DoctorCreateService();
            this._doctorProfileService = new DoctorProfileService();
            this._appointmentCreateService = new AppointmentCreateService();
        }
        public ActionResult Index(int ? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 4;
            var result = _doctorCreateService.GetAll().ToPagedList(pageNumber, pageSize);
            return View(result);
        }

        //public ActionResult GetDoctor(int id)
        //{
        //    var result = doctorCreateService.GetById(id);
        //    return RedirectToAction("DoctorDetails");

        //}
       
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DoctorCreateViewModel doctor)
        {
            //doctor.Speciality = dr["hidden1"].ToString();
            var files = Request.Files;
            if (files.Count > 0)
            {   
                foreach (var file in files.AllKeys)
                {
                    var profileImage = (HttpPostedFileBase)files[file];
                    var imageName = profileImage.FileName;//FileName =Returns the name of the file to be uploaded.
                    var serverPath = Request.MapPath("~/Content/Images/Doctor");
                    var finalPath = Path.Combine(serverPath, imageName);
                    profileImage.SaveAs(finalPath);
                    doctor.Images.ImageUrl = imageName;
                }
            }
            _doctorCreateService.Add(doctor);
            return RedirectToAction("Index");
        }

        public ActionResult Update(DoctorCreateViewModel doctor)
        {
            //doctorService.Update(doctor);
            return RedirectToAction("GetAllDoctors");

        }

        public ActionResult DoctorDetails(int id=0)
        {
            DoctorDetailsService doctorDetailsService = new DoctorDetailsService();
            PatientReviewService patientReviewService = new PatientReviewService();

            var doctor = doctorDetailsService.GetById(id);
            return View(doctor);
        }

        public JsonResult BookAppointment(AppointmentCreateViewModel apointment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _appointmentCreateService.AddAppointment(apointment);
                    return Json(true);
                }
               
            }
            catch(Exception e)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DoctorProfile(int ? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 5;
            var doctorProfile = _doctorProfileService.GetAll().ToPagedList(pageNumber, pageSize); ;
            return View(doctorProfile);
        }

        public ActionResult DoctorDashBoard(int ? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 5;
            var appointments = _appointmentCreateService.GetAllAppointments().ToPagedList(pageNumber, pageSize);
            return View(appointments);
        }

        public ActionResult AppointmentDetails()
        {
            //var doctor = _doctorCreateService.GetById(id);
            return View();
        }
        public ActionResult CallForAppointment()
        {
            //var doctor = doctorService.GetDoctor(1040);
            return View();
        }
        public ActionResult PatientReview(int id,PatientReviewViewModel patientReview)
        {
            PatientReviewService patientReviewService = new PatientReviewService();
            patientReviewService.Add(patientReview);
            return View();
        }
    }
     
}
