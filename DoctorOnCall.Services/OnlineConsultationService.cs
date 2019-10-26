using AutoMapper;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.OnlineConsultations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Services
{
    public class OnlineConsultationService
    {
        private OnlineConsultationRepository onlineConsultationRepository;
        public Mapper Mapper { get; set; }
        public OnlineConsultationService()
        {
            onlineConsultationRepository = new OnlineConsultationRepository();
            Mapper = MapperConfigureService.Configure();
        }

        public void Add(OnlineConsultationViewModel onlineConsultationViewModel)
        {
            var result = Mapper.Map<OnlineConsultationViewModel, OnlineConsultation>(onlineConsultationViewModel);
            onlineConsultationRepository.AddOnlineConsultation(result);
        }
        public List<OnlineConsultationViewModel> GetAll()
        {
            var data = onlineConsultationRepository.GetAll();
            var result = Mapper.Map< List<OnlineConsultation>, List<OnlineConsultationViewModel>>(data);
            return result;
        }
        public OnlineConsultationViewModel GetById(int id)
        {
            var data = onlineConsultationRepository.GetById(id);
            var result = Mapper.Map<OnlineConsultation, OnlineConsultationViewModel>(data);
            return result;
        }
    }
}