using Tutor.Domain.DTO;
using Tutor.Domain.Entities;

namespace Tutor.Application.Contracts.Services
{
    public interface ITutorService
    {
        TutorDTO SearchTutor(TutorDTO tutor);

        TutorEntity CreateTutor(TutorEntity tutor);
    }
}
