using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Account;
using DoctorOnCall.ViewModel.Patient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class LoginService
    {

        private UserRepository userRepository;
        private GenericRepository<User> genericRepository;
        public LoginService()
        {
            userRepository = new UserRepository();
            genericRepository = new GenericRepository<User>();
        }



        public List<LoginViewModel> GetAll()
        {
            var RegisterVM = new List<LoginViewModel>();
            var UserM = genericRepository.Get();
            if (UserM != null && UserM.Count > 0)
            {
                foreach (var patient in UserM)
                {
                    var ent = new LoginViewModel();
                    ent.Email = patient.Email;
                    ent.Password = patient.Password;
                    RegisterVM.Add(ent);
                }
            }

            return RegisterVM;
        }
      


        public LoginViewModel GetById(int id)
        {
            var model = new LoginViewModel();
            var entity = genericRepository.Get(id);
            if (entity!=null)
            {
                model.Email = entity.Email;
                model.Password = entity.Password;


            }

            return model;
        }

    }

     
}
