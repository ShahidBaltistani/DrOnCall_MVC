using AutoMapper;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Services
{
    public class DoctorDetailsService
    {
        private DoctorRepository doctorRepository;
        Mapper Mapper { get; set; }
        public DoctorDetailsService()
        {
            doctorRepository = new DoctorRepository();
            Mapper = MapperConfigureService.Configure();
        }

        public DoctorDetailsViewModel GetById(int id)
        {
            var doctor = doctorRepository.GetDoctor(id);
            var itemModel = Mapper.Map<Doctor, DoctorDetailsViewModel>(doctor);
            return itemModel;
        }
    }
}