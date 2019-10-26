using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class DoctorDashBoardService
    {
        DoctorDashBoardRepository doctorDashBoardRepository = new DoctorDashBoardRepository();
        public List<DoctorDashBoardViewModel> GetAll()
        {
            var doctorDashBoardViewModel = new List<DoctorDashBoardViewModel>();
            var doctorDashBoardM = doctorDashBoardRepository.GetAll();
            if (doctorDashBoardM != null && doctorDashBoardM.Count > 0)
            {
                foreach (var entity in doctorDashBoardM)
                {
                    if (entity != null) continue;
                    var model = new DoctorDashBoardViewModel();
                    var appoint = new Appointment();
                    model.PatientName = appoint.Patient.Name;
                    model.PatientPhoneNumber = appoint.Patient.PhoneNumber;
                    model.DoctorName= appoint.Doctor.Name;
                    model.AppointmentType = appoint.AppointmentType;
                    model.AppointmentStatus = appoint.AppointmentStatus.ToString();
                    model.AppointmentDateTime = appoint.AppointmentTime;

                }


            }

            return doctorDashBoardViewModel;
        }
        public DoctorDashBoardViewModel GetById(int id)
        {
            var doctorDashBoardViewModel = new DoctorDashBoardViewModel();
            var doctorDashBoardM = doctorDashBoardRepository.GetById(id);
            if (doctorDashBoardM != null)
            {

                var model = new DoctorDashBoardViewModel();
                var appoint = new Appointment();
                model.PatientName = appoint.Patient.Name;
                model.DoctorName = appoint.Doctor.Name;
                model.PatientPhoneNumber = appoint.Patient.PhoneNumber;
                model.AppointmentType = appoint.AppointmentType;
                model.AppointmentStatus = appoint.AppointmentStatus.ToString();
                model.AppointmentDateTime = appoint.AppointmentTime;


            }

            return doctorDashBoardViewModel;
        }
    }
}
