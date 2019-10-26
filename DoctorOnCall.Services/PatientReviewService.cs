using AutoMapper;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Repository;
using DoctorOnCall.ViewModel.PatientReviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Services
{
   public class PatientReviewService
    {
      private readonly  PatientReviewRepository patientReviewRepository;
        public Mapper Mapper { get; set; }
        public PatientReviewService()
        {
            patientReviewRepository = new PatientReviewRepository();
            Mapper = MapperConfigureService.Configure();
        }
        public void Add(PatientReviewViewModel patientReview)
        {
            var result = Mapper.Map<PatientReviewViewModel, Comment>(patientReview);
            patientReviewRepository.Add(result);
        }
        public List<PatientReviewViewModel> GetAll()
        {
            var reviews = patientReviewRepository.GetAllPatientReviews();
            var result = Mapper.Map<List<Comment>, List<PatientReviewViewModel>>(reviews);
            return result;
        }
    }
}
