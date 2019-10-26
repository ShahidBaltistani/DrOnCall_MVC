using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;

namespace DoctorOnCall.Repository
{
   public class LocationRepository
    {
        public List<Address> GetAllLocation()
        {
            using (var context = new DoctorOnCallContext())
            {

                return (from l in context.Addresses
                        .Include(x=>x.City)
                        select l).ToList();
            }
            
        }
        public Address GetLocationById(int id)
        {
            using (var context = new DoctorOnCallContext())
            {

                return (from l in context.Addresses
                        .Include(x=>x.City)
                        where l.Id==id
                        select l).FirstOrDefault();
            }

        }
    }
}
