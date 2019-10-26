using DoctorOnCall.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Advertisement
{
    public class Advertisement
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int ImageId { get; set; }
        public virtual List<Image> Images { get; set; }
        public string AdvertisementDetail { get; set; }
    }  
}
