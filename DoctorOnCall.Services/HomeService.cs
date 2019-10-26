using AutoMapper;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Services
{
    public class HomeService
    {
        DoctorRepository doctorRepository;
        public Mapper Mapper { get; set; }
        public HomeService()
        {
            doctorRepository = new DoctorRepository();
            Mapper = MapperConfigureService.Configure();
        }

        public List<HomeViewModel> GetAll()
        {
          var doctors =  doctorRepository.GetAllDoctors();
          var results = Mapper.Map<List<Doctor>, List<HomeViewModel>>(doctors);
            return results;
        }
    }
}