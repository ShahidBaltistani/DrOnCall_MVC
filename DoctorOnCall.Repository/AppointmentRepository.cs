using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.OnlineConsultations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DoctorOnCall.Repository
{
    public class AppointmentRepository
    {
        public void AddAppointment(Appointment model)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                docOnCallContext.Appointments.Add(model);
                docOnCallContext.Entry(model.Doctor).State = EntityState.Unchanged;
                docOnCallContext.Entry(model.Doctor.Address).State = EntityState.Unchanged;
                docOnCallContext.Entry(model.Doctor.Address.City).State = EntityState.Unchanged;
                docOnCallContext.Entry(model.Doctor.Speciality).State = EntityState.Unchanged;
                docOnCallContext.SaveChanges();
            }
        }
        public List<Appointment> GetAll()
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                return (from d in docOnCallContext.Appointments
                        .Include(x => x.Doctor)
                        .Include(x => x.Patient)
                        .Include(x => x.Speciality)
                        select d).ToList();

            }
        }




        //public List<Appointment> GetAllByUserId(int userId)
        //{
        //    using (var docOnCallContext = new DoctorOnCallContext())
        //    {
        //        return (from d in docOnCallContext.Appointments
        //                .Include(x => x.Doctor)
        //                .Include(x => x.Patient)
        //                .Include(x => x.Speciality)
        //                where d.User.Id == userId
        //                select d).ToList();

        //    }
        //}


        public Appointment GetById(int id)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                return (from d in docOnCallContext.Appointments
                        .Include(x => x.Doctor)
                        .Include(x => x.Patient)
                        .Include(x => x.Speciality)
                        select d).First();

            }
        }

        public Appointment GetByUserId(int userId)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                return (from d in docOnCallContext.Appointments select d).First();

            }
        }

        public void Update(Appointment model)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                docOnCallContext.Entry(model).State = System.Data.Entity.EntityState.Modified;

                docOnCallContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                var result = (from p in docOnCallContext.Appointments
                              where p.Id == id
                              select p).First();
                if (result == null) return;
                docOnCallContext.Appointments.Remove(result);
                docOnCallContext.SaveChanges();
            }
        }
    }
}
