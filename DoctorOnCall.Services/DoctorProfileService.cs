using AutoMapper;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Services
{
    public class DoctorProfileService
    {
        private DoctorRepository doctorRepository;
        private GenericRepository<Doctor> genericRepository;
        public Mapper Mapper { get; set; }
        public DoctorProfileService()
        {
            doctorRepository = new DoctorRepository();
            genericRepository = new GenericRepository<Doctor>();
            Mapper = MapperConfigureService.Configure();
        }
        public List<DoctorProfileViewModel> GetAll()
        {
            var Doctors = doctorRepository.GetAllDoctors();
            var itemModel = Mapper.Map<List<Doctor>, List<DoctorProfileViewModel>>(Doctors);

            return itemModel;
        }

        public void Delete(int id)
        {

            doctorRepository.Delete(id);

        }
    }
}