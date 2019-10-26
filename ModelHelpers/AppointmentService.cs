using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class AppointmentService
    {
        private AppointmentRepository appointmentRepository;
        private GenericRepository<Appointment> genericRepository;
        public AppointmentService()
        {
            appointmentRepository = new AppointmentRepository();
            genericRepository = new GenericRepository<Appointment>();
        }

        public List<AppointmentViewModel> GetAll()
        {
            var appointmentVM = new List<AppointmentViewModel>();
            var appointmentM = appointmentRepository.GetAll();
            if (appointmentM != null && appointmentM.Count > 0)
            {
                foreach (var entity in appointmentM)
                {
                    if (entity==null) continue;
                    var doctor = entity.Doctor;
                    var patient = entity.Patient;
                    var model = new AppointmentViewModel();
                    //model.DoctorName = doctor?.FirstName + " " +doctor?.LastName;
                    //model.PatientName = patient?.FirstName + " " + patient?.LastName;
                    model.DoctorName = doctor.Name;
                    model.PatientName = patient.Name;
                    //model.Speciality = entity.Speciality.Name;
                    model.DoctorFee = entity.AppointmentType;
                    model.AppointmentStatus = entity.AppointmentStatus;
                    model.AppointmentTime = entity.AppointmentTime;
                    //model.Location = entity.Location.City.Name;
                    appointmentVM.Add(model);
                }

            }

            return appointmentVM;

        }



        public List<AppointmentViewModel> GetAllByUserId(int userId)
        {
            var appointmentVM = new List<AppointmentViewModel>();
            var appointmentM = appointmentRepository.GetAllByUserId(userId);
            if (appointmentM != null && appointmentM.Count > 0)
            {
                foreach (var entity in appointmentM)
                {
                    if (entity == null) continue;
                    var doctor = entity.Doctor;
                    var patient = entity.Patient;
                    var model = new AppointmentViewModel();
                    //model.DoctorName = doctor?.FirstName + " " +doctor?.LastName;
                    //model.PatientName = patient?.FirstName + " " + patient?.LastName;
                    model.Id = entity.Id;
                    model.DoctorName = doctor.Name;
                    model.PatientName = patient.Name;
                    //model.Speciality = entity.Speciality.Name;
                    model.DoctorFee = entity.AppointmentType;
                    model.AppointmentStatus = entity.AppointmentStatus;

                    model.AppointmentType = entity.AppointmentType;
                    model.AppointmentTime = entity.AppointmentTime;
                    try
                    {
                        //model.Location = entity.Location.Address;
                    }
                    catch(Exception ex)
                    {
                        string a = ex.Message;
                        a = "";
                    }
                    
                    appointmentVM.Add(model);
                }

            }

            return appointmentVM;

        }


        public AppointmentViewModel GetById(int id)
        {
            var model = new AppointmentViewModel();
            var entity = appointmentRepository.GetById(id);
            if (entity != null )
            {
                var doctor = entity.Doctor;
                var patient = entity.Patient;


                //model.DoctorName = entity.Doctor.FirstName + " " + entity.Doctor.LastName;
                //model.PatientName = entity.Patient.FirstName + " " + entity.Patient.LastName;
                model.DoctorName = doctor.Name;
                model.PatientName = patient.Name;
                //model.Speciality = entity.Speciality.Name;
                model.DoctorFee = entity.AppointmentType;
                model.AppointmentStatus = entity.AppointmentStatus;
                model.AppointmentTime = entity.AppointmentTime;
                //model.Location = entity.Location.City.Name;

            }

            return model;

        }
        public void AddAppointment(AppointmentViewModel model)
        {


            var entity = new Appointment()
            {
                Doctor = new DoctorOnCall.Model.Doctors.Doctor()
                {
                    Name = model.DoctorName,
                    DoctorFee = model.DoctorFee,
                },
                Patient = new DoctorOnCall.Model.Patients.Patient()
                {
                    Name = model.PatientName,
                },

                AppointmentTime = model.AppointmentTime,
                //Speciality = new DoctorOnCall.Model.Specialities.Speciality()
                //{
                //    Name = model.Speciality,
                //},
                //Location = new GenericRepository<Location>().Get(x=>x.City.Id==Convert.ToInt32(model.Location)),

                AppointmentStatus = (Status)Convert.ToInt32(model.AppointmentStatus)
           
                
            };
            appointmentRepository.AddAppointment(entity);
        }

        public void Update(AppointmentViewModel model)
        {


            var entity = new Appointment()
            {
                AppointmentTime = model.AppointmentTime,
                Patient = new DoctorOnCall.Model.Patients.Patient()
                {
                    Name = model.PatientName,
                    
                },
                Doctor = new DoctorOnCall.Model.Doctors.Doctor()
                {
                    Name = model.DoctorName,
                    DoctorFee = model.DoctorFee,
                },
                //Speciality = new DoctorOnCall.Model.Specialities.Speciality()
                //{
                //    Name = model.Speciality,
                //},


            };
            genericRepository.Update(entity);
        }
        public void Delete(int id)
        {
            genericRepository.Delete(id);

        }

        //public AppointmentViewModel GetByUserId(int userId)
        //{
        //    var model = new AppointmentViewModel();
        //    var entity = appointmentRepository.GetByUserId(userId);
        //    if (entity != null)
             
        //        model.PatientName = entity.Patient.FirstName + " " + entity.Patient.LastName;
        //        model.DoctorName = entity.Doctor.FirstName + " " + entity.Doctor.LastName;
        //        model.Speciality = entity.Speciality.Id;
        //        model.DoctorFee = entity.Doctor.DoctorFee;
        //        //model.AppointmentStatus = entity.AppointmentStatus;
        //        model.AppointmentTime = entity.AppointmentTime;
        //        model.Location = entity.Location.Id;

        //    //}

        //    return model;

        //}

    }
}