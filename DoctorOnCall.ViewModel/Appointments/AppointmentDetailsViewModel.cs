using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel.Appointments
{
    class AppointmentDetailsViewModel
    {
        public string PatientName { get; set; }

        public string DoctorName { get; set; }

        public string Location { get; set; }

        public DateTime Timings { get; set; }
         
        public string AppointmentStatus { get; set; }

        public string DoctorFee { get; set; }

    }
}
