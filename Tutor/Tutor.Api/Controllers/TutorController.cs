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
        public async Task<IActionResult> SearchTutor([FromQuery]SearchTutorDto tutor)
        {
            try
            {
                var retorno = await _tutorService.SearchTutor(tutor); 
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not find tutor: {ex}");
            }
        }
        
        [HttpPost]
        [Route("CreateTutor")]
        public async Task<IActionResult> CreateTutor ([FromBody]CreateTutorDto tutor)
        {
            try
            {
                var retorno = await _tutorService.CreateTutor(tutor);
                return Ok(retorno);                        
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not create tutor: {ex}");
            }
        }
        
        [HttpPost]
        [Route("UpdateTutor")]
        public IActionResult Update ([FromBody]TutorDto tutor)
        {
            try
            {
                var returno = _tutorService.UpdateTutor(tutor);
                return Ok(tutor);                        
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not update tutor: {ex}");
            }
        }
    }
}
