using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DoctorOnCall.Repository
{
   public class DoctorDashBoardRepository
    {
        public Appointment GetById(int id)
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from p in context.Appointments
                        where p.Id == id
                        select p).First();
            }
        }
        public List<Appointment> GetAll()
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from p in context.Appointments
                        .Include(x=>x.Doctor)
                        .Include(x=>x.Patient)
                        select p).ToList();
            }
        }
    }
}
