using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class DoctorProfileService
    {
        private DoctorRepository doctorRepository;
        //private GenericRepository<Doctor> genericRepository;
        public DoctorProfileService()
        {
            doctorRepository = new DoctorRepository();
            //genericRepository = new GenericRepository<Doctor>();
        }


        public List<DoctorProfileViewModel> GetAll()
        {
            var doctorsVM = new List<DoctorProfileViewModel>();
            var doctorsM = doctorRepository.GetAllDoctors();
            if (doctorsM != null && doctorsM.Count > 0)
            {
                foreach (var doctor in doctorsM)
                {
                    var temp = new DoctorProfileViewModel();
                    temp.Name = doctor.Name;
                    temp.Comment = doctor.Comment;
                    temp.DoctorFee = doctor.DoctorFee;
                    temp.Designation = doctor.Designation;
                    temp.Address =doctor.Address;
                    temp.Speciality = doctor.Speciality;
                    temp.ImageUrl = doctor.ProfileImage;
                    temp.Experience = doctor.Experiences;
                    temp.Qualification = doctor.YourQualifications;
                    doctorsVM.Add(temp);
                }
            }
            return doctorsVM;
        }

    }
}