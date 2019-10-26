using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;

namespace DoctorOnCall.Model.Patients
{
   public class Prescription
    {
        public int Id { get; set; }

        public Patient  Patient { get; set; }
        public Doctor Doctor { get; set; }

        public Address Address { get; set; }

        public string Medecine { get; set; }
        public string Comments { get; set; }


        public DateTime DateAndTime { get; set; }
    }
}
