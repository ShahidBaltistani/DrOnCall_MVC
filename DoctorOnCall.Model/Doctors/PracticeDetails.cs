using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Doctors
{
   public class PracticeDetails
    {
        public int Id { get; set; }
        public string AvailableDay { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public string HospitalName { get; set; }

    }
}
