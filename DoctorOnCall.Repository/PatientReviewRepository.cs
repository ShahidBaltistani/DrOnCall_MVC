using DoctorOnCall.Model.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DoctorOnCall.Model.Common;

namespace DoctorOnCall.Repository
{
   public class PatientReviewRepository
    {
        public void Add(Comment model)
        {
            using (var context = new DoctorOnCallContext())
            {
                context.Comments.Add(model);
                context.SaveChanges();
            }
        }
        public Comment GetUser(int id)
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from p in context.Comments
                        where p.Id == id
                        select p).First();
            }
        }
        public List<Comment> GetAllPatientReviews()
        {
            using (var context = new DoctorOnCallContext())
            {
                return (from p in context.Comments
                        .Include(x=>x.Patient)
                        select p).ToList();
            }
        }
    }
}
