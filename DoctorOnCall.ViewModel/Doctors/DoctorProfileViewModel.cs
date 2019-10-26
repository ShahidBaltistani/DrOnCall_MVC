using DoctorOnCall.Model;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel.Doctors
{
   public class DoctorProfileViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Image Images { get; set; }
        public Speciality Speciality { get; set; }
        public string Designation { get; set; }
        public string DoctorFee { get; set; }
        public string Qualification { get; set; }
        public PracticeDetails PracticeDetails { get; set; }
        public string Experience { get; set; }
        public string ProfessionalStatement { get; set; }
        public virtual Address Address { get; set; }
        public virtual Comment Comment { get; set; }


    }
}
