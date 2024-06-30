using Microsoft.AspNetCore.Mvc;
using Tutor.Application.Services;
using Tutor.Domain.DTO;
using Tutor.Domain.Entities;

namespace TutorApi.Controllers
{
    public class TutorController : Controller
    {
        public readonly TutorServices _tutorService;

        [HttpGet]
        [Route("SearchTutor")]
        public TutorDTO SearchTutor (TutorDTO tutor)
        {
            try
            {
                return _tutorService.SearchTutor(tutor);                                
            }
            catch (Exception ex)
            {
                throw new Exception("Could not find tutor",ex);
            }
        }
        
        [HttpPost]
        [Route("CreateTutor")]
        public TutorDTO CreateTutor (TutorEntity tutor)
        {
            try
            {
                return _tutorService.CreateTutor(tutor);                                
            }
            catch (Exception ex)
            {
                throw new Exception("Could not find tutor",ex);
            }
        }
    }
}
