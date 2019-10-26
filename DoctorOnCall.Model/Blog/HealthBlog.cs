using DoctorOnCall.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model
{
   public class HealthBlog
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public String Content { get; set; }
        public int? ImageId { get; set; }
        public List<Image> Images { get; set; }

    }
}
