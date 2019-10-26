using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel.PatientReviews
{
   public class PatientReviewViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int NumberOfStars { get; set; }
        public ReviewRate ReviewRate { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
