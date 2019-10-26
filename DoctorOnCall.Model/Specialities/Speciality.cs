using DoctorOnCall.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Specialities
{
   public class Speciality
    {
        public Speciality()
        {
            Doctors = new HashSet<Doctor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }


    }
}
