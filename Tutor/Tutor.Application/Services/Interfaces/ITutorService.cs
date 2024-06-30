using Tutor.Domain.DTO;
using Tutor.Domain.Entities;

namespace Tutor.Application.Services.Interfaces
{
    public interface ITutorService
    {
        TutorDTO SearchTutor(TutorDTO tutorDTO);
        TutorDTO CreateTutor(TutorEntity tutorDTO);
    }
}
