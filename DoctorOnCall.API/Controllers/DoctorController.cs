using DoctorOnCall.Services;
using System.Web.Http;

namespace DoctorOnCall.API.Controllers
{
    public class DoctorController : ApiController
    {
        private readonly DoctorCreateService doctorService;
        public DoctorController()
        {
            doctorService = new DoctorCreateService();
        }
        public IHttpActionResult GetAllDoctors()
        {
            var doctors = doctorService.GetAll();
            return Json(doctors);
        }
    }
}
