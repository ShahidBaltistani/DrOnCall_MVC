using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.ViewModel.Doctors
{
    public class DoctorDetailsViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Image Images { get; set; }
        public Speciality Speciality { get; set; }
        public string Designation { get; set; }
        public string DoctorFee { get; set; }
        public string Qualification { get; set; }
        public string Achivement { get; set; }
        public PracticeDetails PracticeDetails { get; set; }
        public string Experience { get; set; }
        public string About { get; set; }
        public string ProfessionalStatement { get; set; }
        public Address Address { get; set; }
        public Comment Comment { get; set; }




    }
}