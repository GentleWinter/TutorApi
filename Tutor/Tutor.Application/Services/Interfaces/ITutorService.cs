using Tutor.Domain.DTO;

namespace Tutor.Application.Services.Interfaces
{
    public interface ITutorService
    {
        Task<TutorDTO> SearchTutor(TutorDTO tutorDTO);
        Task<TutorDTO> CreateTutor(TutorDTO tutorDTO);
        TutorDTO UpdateTutor(TutorDTO tutorDTO);
    }
}
