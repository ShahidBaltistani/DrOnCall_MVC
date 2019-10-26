using DoctorOnCall.Model.Patients;
using DoctorOnCall.Repository;
using DoctorOnCall.Repository.Common;
using DoctorOnCall.ViewModel.Patient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class UserService
    {

        private UserRepository patientRepository;
        private GenericRepository<Patient> genericRepository;
        public UserService()
        {
            patientRepository = new UserRepository();
            genericRepository = new GenericRepository<Patient>();
        }



        public List<UserViewModel> GetAll()
        {
            var patientVM = new List<UserViewModel>();
            var patientM = patientRepository.GetAllUsers();
            if (patientM != null && patientM.Count > 0)
            {
                foreach (var patient in patientM)
                {
                    var ent = new UserViewModel();
                    //ent.Name = patient.FirstName + " " + patient.LastName;
                    ent.Name = patient.Name;
                    ent.Email = patient.Email;
                    ent.PhoneNumber = patient.PhoneNumber;
                    ent.Password = patient.Password;
                    patientVM.Add(ent);
                }
            }

            return patientVM;
        }
        public void CreateUser(UserViewModel user)
        {
            var entity = new Patient()
            {
               Name = user.Name,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Password = user.Password

            };
            patientRepository.AddUser(entity);
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
