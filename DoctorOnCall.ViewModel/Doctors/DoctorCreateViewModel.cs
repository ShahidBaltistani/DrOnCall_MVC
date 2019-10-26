using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Patients;

using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctorOnCall.Model.UserManagements;

namespace DoctorOnCall.ViewModel.Doctors
{
    public class DoctorCreateViewModel 
    {
        public int DoctorId { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string Gender { get; set; }
        public string ConfirmPassword { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public virtual Image Images { get; set; }

        public bool Remember { get; set; }
        public string CNIC_Number { get; set; }

        public Speciality Speciality { get; set; }

        public string PmdcNumber { get; set; }

        public string Designation { get; set; }

        public string DoctorFee { get; set; }

        public string VedioLinks { get; set; }

        public string Qualification { get; set; }
        public string Achivement { get; set; }

        public PracticeDetails PracticeDetails { get; set; }

        public string Document { get; set; }

        public string Experience { get; set; }

        public string About { get; set; }
        public string ProfessionalStatement { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }

    }
}