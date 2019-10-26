using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Doctors
{
   public class Doctor:User
    {
        public Doctor()
        {
            Comments = new HashSet<Comment>();
            Patients = new HashSet<Patient>();
            Appointments = new HashSet<Appointment>();
            OnlineConsultations = new HashSet<OnlineConsultation>();
        }
        public int DoctorId { get; set; }


        public string CNIC_Number { get; set; }

        public int? SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        
        public string PmdcNumber { get; set; }
        //[StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]

        public string Designation { get; set; }

        //[Required(ErrorMessage = "Please enter name"), MaxLength(30)]

        public string DoctorFee { get; set; }

        public string VedioLinks { get; set; }
        public string Document { get; set; }
        [StringLength(500)]
        public string Qualification { get; set; }
        [StringLength(500)]
        public string Achivement { get; set; }

        public int? PracticeDetailsId { get; set; }
        [StringLength(500)]

        public virtual PracticeDetails PracticeDetails { get; set; }
        [StringLength(500)]

        public string Experience { get; set; }
        [StringLength(1000)]

        public string About { get; set; }
        [StringLength(1000)]

        public string ProfessionalStatement { get; set; }

        public int? AddressId { get; set; }
        [StringLength(500)]

        public Address Address { get; set; }


        //public object Patient { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<OnlineConsultation> OnlineConsultations { get; set; }


    }
}
