using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Appointments
{
    public class Appointment
    {
        public int Id { get; set; }
        public string AppointmentType { get; set; }
        public DateTime AppointmentTime { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Speciality Speciality { get; set; }
        public Status AppointmentStatus { get; set; }

    }


}
