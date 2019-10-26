using DoctorOnCall.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Repository
{ 
  public class DoctorRepository
    {
        public void AddDoctor(Doctor model)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                docOnCallContext.Doctors.Add(model);
                docOnCallContext.SaveChanges();
            }
        }
        public List<Doctor> GetAllDoctors()
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                return (from d in docOnCallContext.Doctors
                        .Include(x=>x.Address.City)
                        .Include(x=>x.Comment)
                        select d).ToList();
                
            }
        }

        public Doctor GetDoctor(int id)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                  return (from d in docOnCallContext.Doctors
                         .Include(x => x.Address.City)
                        .Include(x => x.Speciality)
                        .Include(x => x.Comment)

                          where d.Id==id
                        select d).AsNoTracking().FirstOrDefault();

            }
        }
        public void Delete(int id)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                var data= (from d in docOnCallContext.Doctors
                        where d.Id == id
                        select d).First();
                if (data == null) return;
                docOnCallContext.Doctors.Remove(data);
                docOnCallContext.SaveChanges();
            }
        }
        public void Update(Doctor model)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                docOnCallContext.Entry(model).State = EntityState.Modified;
                docOnCallContext.SaveChanges();
            }
        }
    }
}
