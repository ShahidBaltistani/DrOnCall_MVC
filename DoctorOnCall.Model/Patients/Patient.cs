using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.OnlineConsultations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Patients
{
   public class Patient:User
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
            Comments = new HashSet<Comment>();
            OnlineConsultations = new HashSet<OnlineConsultation>();

        }
        public int PatientId { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OnlineConsultation> OnlineConsultations { get; set; }


    }
}
