using DoctorOnCall.Model.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DoctorOnCall.Model.Common;

namespace DoctorOnCall.Repository
{
   public class UserDashBoardRepository
    {
        public List<Appointment> GetUserAppoinments()
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from a in context.Appointments
                        .Include(x=>x.Doctor)
                        .Include(x=>x.Patient)
                        select a).ToList();

            }
        }

        public User GetById(int id)
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from u in context.Users
                        .Include("Role")
                        where u.Id == id
                        select u).FirstOrDefault();

            }
        }
        

    }
}
