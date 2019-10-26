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
    public class DoctorCreateService
    {
        private DoctorRepository doctorRepository;
        //private GenericRepository<Doctor> genericRepository;
        public Mapper Mapper { get; set; }
        public DoctorCreateService()
        {
            doctorRepository = new DoctorRepository();
            //genericRepository = new GenericRepository<Doctor>();
            Mapper = MapperConfigureService.Configure();
        }
        public void Add(DoctorCreateViewModel doctorVM)
        {
            var itemModel = Mapper.Map<DoctorCreateViewModel, Doctor>(doctorVM);
            doctorRepository.AddDoctor(itemModel);

        }
        public DoctorCreateViewModel GetById(int id)
        {
            var doctor = doctorRepository.GetDoctor(id);
            var itemModel = Mapper.Map<Doctor, DoctorCreateViewModel>(doctor);
            return itemModel;
        }
        public List<DoctorCreateViewModel> GetAll()
        {
            var Doctors = doctorRepository.GetAllDoctors();
            var itemModel = Mapper.Map<List<Doctor>,List<DoctorCreateViewModel>>(Doctors);

            return itemModel;
        }

        public void Delete(int id)
        {

            doctorRepository.Delete(id);

        }
    }
}