using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.ViewModel
{
   public class HomeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Image Images { get; set; }
        public Speciality Speciality { get; set; }
        public Comment Comment { get; set; }

    }
}
