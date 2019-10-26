using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel.Appointments
{
   public class AppointmentCreateViewModel
    {

        public int Id { get; set; }
        public string AppointmentType { get; set; }
        public DateTime AppointmentTime { get; set; }
        //public string Name { get; set; }
        //public string PhoneNumber { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Status AppointmentStatus { get; set; }
    }
}
