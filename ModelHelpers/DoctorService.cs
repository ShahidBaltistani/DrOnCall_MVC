using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.DoctorsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.Model
{
    public class DoctorService
    {
        private DoctorRepository doctorRepository;
        private GenericRepository<Doctor> genericRepository;
        public DoctorService()
        {
            doctorRepository = new DoctorRepository();
            genericRepository = new GenericRepository<Doctor>();
        }
 

        public List<DoctorViewModel> GetAll()
        {
            var doctorsVM = new List<DoctorViewModel>();
            var doctorsM = doctorRepository.GetAllDoctors();
            if (doctorsM != null && doctorsM.Count > 0)
            {
                foreach (var doctor in doctorsM)
                {
                    var temp = new DoctorViewModel();
                    temp.Id = doctor.Id;
                    //temp.Name = doctor.FirstName + " " + doctor.LastName;
                    temp.Name = doctor.Name;
                    temp.DoctorFee = doctor.DoctorFee;
                    temp.StreetAddress = doctor?.Address?.StreetAddress;
                    temp.City = doctor.Address?.City?.Name;
                    temp.Designation = doctor.Designation;
                    temp.Email = doctor.Email;
                    temp.PhoneNumber = doctor.PhoneNumber;
                    temp.Speciality = doctor.Speciality?.Name;
                    temp.ProfileImage = doctor.Images.ImageUrl;
                    temp.VedioLinks = doctor.VedioLinks;
                    temp.YourQualifications = doctor.Qualification;

                    doctorsVM.Add(temp);
                }
            }
            return doctorsVM;
        }

        public DoctorViewModel GetDoctor(int id)
        {
            var doctorsVM = new DoctorViewModel();
            var doctorsM = doctorRepository.GetDoctor(id);

            //doctorsVM.Name = doctorsM.FirstName + " " + doctorsM.LastName;
            doctorsVM.Name = doctorsM.Name;
            doctorsVM.DoctorFee = doctorsM.DoctorFee;
            doctorsVM.StreetAddress = doctorsM.Address.StreetAddress;
            doctorsVM.City = doctorsM.Address.City.Name;
            doctorsVM.Designation = doctorsM.Designation;
            doctorsVM.Email = doctorsM.Email;
            doctorsVM.PhoneNumber = doctorsM.PhoneNumber;
            doctorsVM.ProfileImage = doctorsM.Images.ImageUrl;
            doctorsVM.VedioLinks = doctorsM.VedioLinks;
            doctorsVM.YourQualifications = doctorsM.Qualification;
            return doctorsVM;
        }


        public void Add(DoctorCreateViewModel doctorsCVM)
        {
            
            var doctorM = new Doctor()
            {

            //FirstName = doctorsCVM.FirstName,
            //LastName = doctorsCVM.LastName,
                Name = doctorsCVM.Name,
                Email = doctorsCVM.Email,
                Password = doctorsCVM.Password,
                PhoneNumber = doctorsCVM.PhoneNumber,
                CNIC_Number = doctorsCVM.CNIC_Number,
                Age = doctorsCVM.Age,
                Achivement = doctorsCVM.Achivement,
                Images = doctorsCVM.Document,
                DoctorFee = doctorsCVM.DoctorFee,
                PmdcNumber = doctorsCVM.PmdcNumber,
                Speciality = doctorsCVM.Speciality,
                Designation = doctorsCVM.Designation,
                VedioLinks = doctorsCVM.VedioLinks,
                Address =new Address { StreetAddress = doctorsCVM.StreetAddress.StreetAddress,
                City =new City {Name= doctorsCVM.City.Name } } ,
                
                Experience = doctorsCVM.Experiences,
                Gender = doctorsCVM.Gender,
                //Images = doctorsCVM.ProfileImage,
                Qualification = doctorsCVM.Qualification,
            };


            doctorRepository.AddDoctor(doctorM);

        }

        //public void Update(DoctorViewModel doctorsVM)
        //{
        //    var doctorM = new Doctor()
        //    {
        //        //FirstName = doctorsVM.Name.Split(' ')[0],
        //        //LastName = doctorsVM.Name.Split(' ')[1],
        //        Name = doctorsVM.Name,
        //        Email = doctorsVM.Email,
        //        Achivement = doctorsVM.Achivements,
        //        Image = doctorsVM.ChoseFiles,
        //        DoctorFee = doctorsVM.DoctorFee,
        //        Designation = doctorsVM.Designation,
        //        VedioLinks = doctorsVM.VedioLinks,
        //        Experiences = doctorsVM.Experiences,
        //        ProfileImage = doctorsVM.ProfileImage,
        //        YourQualifications = doctorsVM.YourQualifications,
        //    };

        //    doctorRepository.Update(doctorM);

        //}
        public void Delete(int id)
        {

            doctorRepository.Delete(id);

        }
    }
}