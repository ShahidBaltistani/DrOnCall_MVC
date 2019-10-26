using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Model.Patients;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Repository
{
   public class UserSignUpRepository
    {
        public void Add(Patient model)
        {
            using (var context = new DoctorOnCallContext())
            {
                context.Patients.Add(model);
                context.SaveChanges();
            }
        }
        public Patient GetById(int id)
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from p in context.Patients
                        .Include("Role")
                        where p.Id == id
                        select p).First();
            }
        }
        public Patient GetUser(string email, string password)
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from p in context.Patients
                        .Include("Role")
                        where p.Email.Equals(email) && p.Password.Equals(password)
                        select p).FirstOrDefault();
            }
        }
        public List<Patient> GetAll()
        {
            using (var context = new DoctorOnCallContext())
            {
                return  (from p in context.Patients
                         .Include("Role")
                          select p).ToList();
            }
        }
        public void Delete(int id)
        {
            using (var context = new DoctorOnCallContext())
            {
                var patient = (from p in context.Patients
                               where p.Id == id
                               select p).First();
            }
        }
        public void Update(Patient model)
        {
            using (var context = new DoctorOnCallContext())
            {
                context.Entry(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
