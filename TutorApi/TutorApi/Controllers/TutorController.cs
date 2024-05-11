using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using TutorApi.Application.Contracts.Services;
using TutorApi.Domain.DTO;

namespace TutorApi.Controllers
{
    public class TutorController : Controller
    {
        public readonly ITutorService _tutorService;

        [HttpGet]
        [Route("GetTutorByCPF")]
        public TutorDTO GetTutorByCPF (string cpf)
        {
            try
            {
                return _tutorService.GetTutorByCPF(cpf);                                
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
