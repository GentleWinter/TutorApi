using Tutor.Application.Services.Interfaces;
using Tutor.Domain.DTO;
using Tutor.Domain.Entities;
using Tutor.Infra.Repositories.Interfaces;

namespace Tutor.Application.Services
{
    public class TutorService : ITutorService
    {

        private readonly ITutorRepository _tutorRepository;
        public TutorService(ITutorRepository tutorRepository) 
        {
            _tutorRepository = tutorRepository;
        }


        public async Task<TutorDTO> CreateTutor(TutorDTO tutor)
        {
            TutorEntity tutorEntity = new TutorEntity()
            {
                Name = tutor.Name,
                Document = tutor.Document,
                Email = tutor.Email
            };

            await _tutorRepository.Add(tutorEntity);
            _tutorRepository.SaveChanges();

            return tutor;
        }

        public async Task<TutorDTO> SearchTutor(TutorDTO tutor)
        {
            TutorEntity tutorEntity = new TutorEntity()
            {
                Name = tutor.Name,
                Document = tutor.Document,
                Email = tutor.Email
            };

            var retorno = await _tutorRepository.Get(tutorEntity);

            return new TutorDTO() 
            {
                Document = retorno.Document,
                Email = retorno.Email,
                Name = retorno.Name
            };
        }

        public TutorDTO UpdateTutor(TutorDTO tutor)
        {
            TutorEntity tutorEntity = new TutorEntity()
            {
                Name = tutor.Name,
                Document = tutor.Document,
                Email = tutor.Email,
                Password = tutor.Password
            };

            var retorno = _tutorRepository.Update(tutorEntity);
            _tutorRepository.SaveChanges();

            return new TutorDTO()
            {
                Document = retorno.Document,
                Email = retorno.Email,
                Name = retorno.Name
            };
        }
    }
}
