using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class OnlineConsultationService
    {
        private GenericRepository<Doctor> genericRepository;
        private OnlineConsultationRepository onlineConsultationRepository;

        public OnlineConsultationService()
        {
            genericRepository = new GenericRepository<Doctor>();
            onlineConsultationRepository = new OnlineConsultationRepository();
        }

      
        public List<OnlineConsultationViewModel> GetAll()
        {
            var onlineConsultationVM = new List<OnlineConsultationViewModel>();
            var onlineConsultationM = onlineConsultationRepository.GetAll();
            if (onlineConsultationM != null && onlineConsultationM.Count > 0)
            {
                foreach (var entity in onlineConsultationM)
                {
                    if (entity == null) continue;
                    var patient = entity.Patient;
                    var model = new OnlineConsultationViewModel();
                    if (patient==null)
                    {
                        continue;
                    }
                    //model.Name = patient.FirstName + " " +patient.LastName;
                    model.Name = patient.Name;
                    model.PhoneNumber = patient.PhoneNumber;
                    model.Email = patient.Email;
                   model.Speciality = entity.Speciality.Name;
                    onlineConsultationVM.Add(model);
                }

            }

            return onlineConsultationVM;

        }

        public OnlineConsultationViewModel GetById(int id)
        {
            var model = new OnlineConsultationViewModel();
            var entity = onlineConsultationRepository.GetById(id);
            if (entity != null )
            {
                //model.Name = entity.Patient.FirstName+ " " + entity.Patient.LastName;
                    model.Name = entity.Patient.Name;
                    model.PhoneNumber = entity.Patient.PhoneNumber;
                    model.Email = entity.Patient.Email;
                    model.Speciality = entity.Speciality.Name;

            }

            return model;

        }
        public void AddOnlineConsultation(OnlineConsultationViewModel model)
        {


            var entity = new OnlineConsultation()
            {
                Speciality = new DoctorOnCall.Model.Specialities.Speciality()
                {
                    Name = model.Speciality
                },
                Patient = new DoctorOnCall.Model.Patients.Patient()
                {
                    Name = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                },
                PaymentMethod = model.PaymentMethod,
                DateAndTime=DateTime.Now


            };
            onlineConsultationRepository.AddOnlineConsultation(entity);
        }

        public void Update(OnlineConsultationViewModel model)
        {


            var entity = new OnlineConsultation()
            {
                Speciality = new DoctorOnCall.Model.Specialities.Speciality()
                {
                    Name = model.Speciality
                },
                Patient = new DoctorOnCall.Model.Patients.Patient()
                {
                   Name = model.Name,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber
                },
                PaymentMethod = model.PaymentMethod


            };
            onlineConsultationRepository.Update(entity);
        }
        public void Delete(int id)
        {
            onlineConsultationRepository.Delete(id);

        }

        public OnlineConsultationViewModel GetByUserId(int userId)
        {
            var model = new OnlineConsultationViewModel();
            var entity = onlineConsultationRepository.GetByUserId(userId);
            if (entity != null)
            {
                //model.Name = entity.Patient.FirstName + " " + entity.Patient.LastName;
                model.Name = entity.Patient.Name;
 
                model.Speciality = entity.Speciality.Name;

            }

            return model;

        }


    }
}