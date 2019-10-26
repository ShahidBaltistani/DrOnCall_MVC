using DoctorOnCall.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Repository
{
   public class AsjadRepository
    {
        public void AddData(Doctor model)
        {
            using (var context= new DoctorOnCallContext())
            {
               var d= context.Doctors.Add(model);
                context.SaveChanges();
            }
        }
    }
}
