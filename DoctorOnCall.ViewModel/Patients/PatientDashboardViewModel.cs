using System;

namespace DoctorOnCall.ViewModel.Patients
{
    public class PatientDashboardViewModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PatientPicture { get; set; }
        public string Status { get; set; }
        public string Hour { get; set; }
        public DateTime  DateTime { get; set; }

    }
}