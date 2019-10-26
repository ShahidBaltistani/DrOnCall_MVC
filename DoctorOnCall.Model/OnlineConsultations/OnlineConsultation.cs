using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.OnlineConsultations
{
    public class OnlineConsultation
    {
        public int Id { get; set; }
        public int? SpecialityId { get; set; }

        public Speciality Speciality { get; set; }

        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int? PatientId { get; set; }

        public Patient Patient { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]

        public DateTime DateAndTime { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public Status ConsultationStatus { get; set; }

    }
}
