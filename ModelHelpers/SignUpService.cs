using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel.Account;
using DoctorOnCall.ViewModel.Patient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class SignUpService
    {

        private UserRepository userRepository;
        private GenericRepository<User> genericRepository;
        public SignUpService()
        {
            userRepository = new UserRepository();
            genericRepository = new GenericRepository<User>();
        }



        public List<SignUpViewModel> GetAll()
        {
            var RegisterVM = new List<SignUpViewModel>();
            var UserM = genericRepository.Get();
            if (UserM != null && UserM.Count > 0)
            {
                foreach (var patient in UserM)
                {
                    var ent = new SignUpViewModel();
                    //ent.Name = patient.FirstName + " " + patient.LastName;
                    ent.Name = patient.Name;
                    ent.Email = patient.Email;
                    ent.PhoneNumber = patient.PhoneNumber;
                    ent.Password = patient.Password;
                    RegisterVM.Add(ent);
                }
            }

            return RegisterVM;
        }
        public void CreateUser(SignUpViewModel user)
        {
            var entity = new User()
            {
               Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Password = user.Password

            };
            userRepository.AddUser(entity);
        }

        public void Update(UserViewModel user)
        {
            var entity = new Patient()
            {
                Name = user.Name,
                //LastName = user.Name.Split(' ')[1],
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Password = user.Password

            };
            genericRepository.Update(entity);
        }

        public UserViewModel GetById(int id)
        {
            var model = new UserViewModel();
            var entity = genericRepository.Get(id);
            if (entity!=null)
            {
                model.Name = entity.Name;
                model.Email = entity.Email;
                model.PhoneNumber = entity.PhoneNumber;
            
            }
          
           return model;
        }

        public void Delete(int id)
        {
            genericRepository.Delete(id);
        }
    }

     
}
