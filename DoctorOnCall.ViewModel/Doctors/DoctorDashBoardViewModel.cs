using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel.Doctors
{
   public class DoctorDashBoardViewModel
    {
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string AppointmentType { get; set; }
        public string PatientPhoneNumber { get; set; }
        public string AppointmentStatus { get; set; }


    }
}
