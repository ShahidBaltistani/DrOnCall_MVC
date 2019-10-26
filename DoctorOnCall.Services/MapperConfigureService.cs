using DoctorOnCall.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DoctorOnCall.ViewModel.Doctors;
using DoctorOnCall.Services;
using DoctorOnCall.Model.Appointments;
using DoctorOnCall.ViewModel.Account;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.ViewModel.Appointments;
using DoctorOnCall.ViewModel.OnlineConsultations;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.PatientReviews;
using DoctorOnCall.Model.Common;

namespace DoctorOnCall.Services
{
    public class MapperConfigureService : Profile
    {
        public MapperConfigureService()
        {
            /////Doctors/////
            CreateMap<Doctor, DoctorCreateViewModel>()
                .ForMember(dest => dest.StreetAddress,opt => opt.MapFrom(src => src.Address.StreetAddress))
                .ForMember(dest => dest.City,opt => opt.MapFrom(src => src.Address.City.Name));
            CreateMap<Doctor, DoctorProfileViewModel>();
            CreateMap<DoctorCreateViewModel, Doctor>();


            //////Appointment///////////// 
            CreateMap<AppointmentCreateViewModel, Appointment>();
            CreateMap<Appointment, AppointmentCreateViewModel>();

            //CreateMap<Appointment, AppointmentCreateViewModel>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Patient.Name))
            //    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Patient.PhoneNumber));


            CreateMap<SignUpViewModel, Patient>();
            CreateMap<Patient, SignUpViewModel>();
            CreateMap<Doctor, DoctorDetailsViewModel>();
            CreateMap<OnlineConsultationViewModel, OnlineConsultation>();
            CreateMap<OnlineConsultation, OnlineConsultationViewModel>();
            CreateMap<Doctor, HomeViewModel>();
            CreateMap<PatientReviewViewModel, Comment>();
            CreateMap<Comment, PatientReviewViewModel>();




        }
        public static Mapper Configure()
        {
            var config = new MapperConfiguration(c => c.AddProfile(new MapperConfigureService()));
            return new Mapper(config);
        }

    }
}
