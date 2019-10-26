using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.UserManagements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Model.Common
{
    public class User
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        //[DataType(DataType.Text)]
        public string Name { get; set; }
        //[DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string Password { get; set; }
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]

        public string Email { get; set; }

        public int? ImageId { get; set; }
        public virtual Image Images { get; set; }

        public bool Remember { get; set; }
        public bool IsActive { get; set; }
        public Comment Comment { get; set; }
        public Role Role { get; set; }
        public bool IsInRole(int id)
        {
            return Role != null && Role.Id == id;
        }
    }
}
