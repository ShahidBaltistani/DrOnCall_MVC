﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Doctors
{
   public class Address
    {
        public int Id { get; set; }

        public string StreetAddress { get; set; }

        public int? CityId { get; set; }

        public City City { get; set; }
      
    }
}
