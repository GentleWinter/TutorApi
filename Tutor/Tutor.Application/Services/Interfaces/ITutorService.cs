using Tutor.Domain.DTO;

namespace Tutor.Application.Services.Interfaces
{
    public interface ITutorService
    {
        Task<TutorDto> SearchTutor(SearchTutorDto tutorDTO);
        Task<TutorDto> CreateTutor(CreateTutorDto tutorDTO);
        TutorDto UpdateTutor(TutorDto tutorDTO);
    }
}
