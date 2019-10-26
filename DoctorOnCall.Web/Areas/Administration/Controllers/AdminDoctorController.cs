using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.Services;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Doctors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorOnCall.Web.Areas.Administration.Controllers

{
    public class AdminDoctorController : Controller
    {
        DoctorCreateService doctorService = new DoctorCreateService();
        DoctorOnCallContext db = new DoctorOnCallContext();

        public ActionResult Index()
        {
            //if (searchBy=="Name")
            //{
            //    var result = db.Doctors.Where(x => x.Name.StartsWith(search) || search == null).ToList();
            //    return View(result);
            //}
            //else
            //{
            //    var result = db.Doctors.Where(x=>x.DoctorFee == search || search ==null).ToList();
            //    return View(result);
            //}
          var doctors=  doctorService.GetAll();
            return View(doctors);


        }

        public ActionResult GetDoctor(int id)
        {
            var result = doctorService.GetById(id);
            return RedirectToAction("DoctorDetails");

        }

        public ActionResult DeleteDoctor(int id)
        {
            doctorService.Delete(id);
            return RedirectToAction("GetAllDoctors");
        }
        //public ActionResult Update(DoctorCreateViewModel doctor)
        //{
        //    doctorService.Update(doctor);
        //    return RedirectToAction("GetAllDoctors");

        //}

        //public ActionResult DoctorDetails()
        //{
        //    var doctor = doctorService.GetDoctor(6);

        //    return View(doctor);
        //}

        //public ActionResult DoctorProfile()
        //{
        //    ViewBag.data = "Advertisements";
        //    ViewBag.data2 = "Best ENT Specialist In Lahore Pakistan";
        //    var doctor = doctorService.GetDoctor(1040);

        //    return View(doctor);
        //}
    }

}
