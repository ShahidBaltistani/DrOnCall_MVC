using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DoctorOnCall.Web.ModelHelpers
{
    public class UserDashBoardServices
    {
        UserDashBoardRepository userDashBoardRepository = new UserDashBoardRepository();
        public List<UserDashBoardViewModel> GetAll()
        {
            var userDashBoardVM = new List<UserDashBoardViewModel>();
          var userDashBoardM =  userDashBoardRepository.GetUserAppoinments();
            if (userDashBoardM != null && userDashBoardM.Count >0)
            {
                foreach (var entity in userDashBoardM)
                {
                    if (entity != null) continue;
                    var model = new UserDashBoardViewModel();
                    var appoint = new Appointment();
                    model.PatientName = appoint.Patient.Name;
                    model.UserName =appoint.Patient.Name;
                    model.ServiceType = appoint.AppointmentType;
                    model.AppointmentStatus = appoint.AppointmentStatus.ToString();
                    model.DateTime = appoint.AppointmentTime;
                 
                }
               

            }

            return userDashBoardVM;
        }
        public UserDashBoardViewModel GetById(int id)
        {
            var userDashBoardVM = new UserDashBoardViewModel();
            var userDashBoardM = userDashBoardRepository.GetById(id);
            if (userDashBoardM != null)
            {
               
                    var model = new UserDashBoardViewModel();
                    var appoint = new Appointment();
                    model.PatientName = appoint.Patient.Name;
                    model.UserName =appoint. Patient.Name;
                    model.ServiceType = appoint.AppointmentType;
                    model.AppointmentStatus = appoint.AppointmentStatus.ToString();
                    model.DateTime = appoint.AppointmentTime;


            }

            return userDashBoardVM;
        }
    }
}