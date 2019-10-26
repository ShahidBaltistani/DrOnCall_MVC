using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel.OnlineConsultations
{
    public class OnlineConsultationViewModel
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

