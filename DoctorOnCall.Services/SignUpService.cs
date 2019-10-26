using AutoMapper;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Services
{
    public class SignUpService
    {
        UserSignUpRepository userSignUpRepository;
        public Mapper Mapper { get; set; }
        public SignUpService()
        {
            userSignUpRepository = new UserSignUpRepository();
            Mapper = MapperConfigureService.Configure();
        }
        public void AddUser(SignUpViewModel signUpVM)
        {
            var itemModel = Mapper.Map<SignUpViewModel, Patient>(signUpVM);
            userSignUpRepository.Add(itemModel);
        }
        public List<SignUpViewModel> GetAll()
        {
            var users = userSignUpRepository.GetAll();
            var itemModel = Mapper.Map<List<Patient>, List<SignUpViewModel>>(users);
            return itemModel;
        }
    }
}