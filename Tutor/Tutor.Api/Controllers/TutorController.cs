using Microsoft.AspNetCore.Mvc;
using Tutor.Application.Services.Interfaces;
using Tutor.Domain.DTO;

namespace TutorApi.Controllers
{
    public class TutorController : Controller
    {
        private readonly ITutorService _tutorService;
        public TutorController(ITutorService tutorService)
        {
            _tutorService = tutorService;
        }

        [HttpGet]
        [Route("SearchTutor")]
        public IActionResult SearchTutor (TutorDTO tutor)
        {
            try
            {
                _tutorService.SearchTutor(tutor); 
                return Ok(tutor);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not find tutor: {ex}");
            }
        }
        
        [HttpPost]
        [Route("CreateTutor")]
        public IActionResult CreateTutor ([FromBody]TutorDTO tutor)
        {
            try
            {
                var returno = _tutorService.CreateTutor(tutor);
                return Ok(tutor);                        
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not create tutor: {ex}");
            }
        }
        
        [HttpPost]
        [Route("UpdateTutor")]
        public IActionResult Update ([FromBody]TutorDTO tutor)
        {
            try
            {
                var returno = _tutorService.UpdateTutor(tutor);
                return Ok(tutor);                        
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not create tutor: {ex}");
            }
        }
    }
}
