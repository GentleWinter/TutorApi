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


        public async Task<TutorDto> CreateTutor(CreateTutorDto tutor)
        {
            TutorEntity tutorEntity = new TutorEntity()
            {
                Name = tutor.Name,
                Document = tutor.Document,
                Email = tutor.Email,
                Password = Guid.NewGuid().ToString().Replace("-", "")
            };

            var tutorNew = await _tutorRepository.Add(tutorEntity);
            _tutorRepository.SaveChanges();

            return new TutorDto()
            {
                Id = tutorNew.Id,
                Document = tutorNew.Document,
                Email = tutorNew.Email,
                Name = tutorNew.Name,
                Password = tutorNew.Password
            };
        }

        public async Task<TutorDto> SearchTutor(SearchTutorDto tutor)
        { 
            var tutorEntity = await _tutorRepository.FirstOrDefault(t => t.Document == tutor.Document 
                                                                     || t.Id == tutor.Id);

            return new TutorDto() 
            {
                Id = tutorEntity.Id,
                Document = tutorEntity.Document,
                Email = tutorEntity.Email,
                Name = tutorEntity.Name
            };
        }

        public TutorDto UpdateTutor(TutorDto tutor)
        {
            var tutorEntity = new TutorEntity()
            {
                Id = tutor.Id,
                Name = tutor.Name,
                Document = tutor.Document,
                Email = tutor.Email,
                Password = tutor.Password,
                BirthDate = tutor.BirthDate
            };

            var retorno = _tutorRepository.Update(tutorEntity);
            _tutorRepository.SaveChanges();

            return new TutorDto()
            {
                Document = retorno.Document,
                Email = retorno.Email,
                Name = retorno.Name
            };
        }
    }
}
