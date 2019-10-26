using DoctorOnCall.Model.OnlineConsultations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Repository
{
   public class OnlineConsultationRepository
    {
        public void AddOnlineConsultation(OnlineConsultation model)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                docOnCallContext.OnlineConsultations.Add(model);
                docOnCallContext.SaveChanges();
            }
        }
        public List<OnlineConsultation> GetAll()
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {

                return (from d in docOnCallContext.OnlineConsultations
                        .Include(x=> x.Patient)
                       .Include(x => x.Speciality)
                        select d).ToList();

            }
        }

        public OnlineConsultation GetById(int id)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                return (from d in docOnCallContext.OnlineConsultations
                        where d.Id==id
                        select d).First();

            }
        }

        public OnlineConsultation GetByUserId(int userId)
        {
            using (var docOnCallContext = new DoctorOnCallContext())
            {
                return (from d in docOnCallContext.OnlineConsultations select d).First();

            }
        }

        public void Update(OnlineConsultation model)
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
                var result = (from p in docOnCallContext.OnlineConsultations
                              where p.Id == id
                              select p).First();
                if (result == null) return;
                docOnCallContext.OnlineConsultations.Remove(result);
                docOnCallContext.SaveChanges();
            }
        }
    }
}
