using AutoMapper;
using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Services
{
    public class AppointmentCreateService
    {
        private AppointmentRepository appointmentRepository;
        private DoctorRepository doctorRepository;
        public Mapper Mapper { get; set; }
        public AppointmentCreateService()
        {
            appointmentRepository = new AppointmentRepository();
            doctorRepository = new DoctorRepository();
            Mapper = MapperConfigureService.Configure();
        }

        public void AddAppointment(AppointmentCreateViewModel appointmentVM)
        {
            var itemModel = Mapper.Map<AppointmentCreateViewModel, Appointment>(appointmentVM);
            itemModel.Doctor = doctorRepository.GetDoctor(appointmentVM.Doctor.DoctorId);
            appointmentRepository.AddAppointment(itemModel);
        }
        public List<AppointmentCreateViewModel> GetAllAppointments()
        {
            var Appointments = appointmentRepository.GetAll();
            var itemModel = Mapper.Map<List<Appointment>, List<AppointmentCreateViewModel>>(Appointments);
            return itemModel;
        }
        public AppointmentCreateViewModel GetById(int id)
        {
            var appointment = appointmentRepository.GetById(id);
            var modelitem = Mapper.Map<Appointment, AppointmentCreateViewModel>(appointment);
            return modelitem;
        }
    }
}