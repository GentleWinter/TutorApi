using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorApi.Application.Contracts.Services;
using TutorApi.Application.Queries;
using TutorApi.Domain.DTO;
using TutorApi.Domain.Entities;

namespace TutorApi.Application.Services
{
    internal class TutorServices : ITutorService
    {
        private readonly ITutorService _tutorRepository;

        public TutorServiceImpl(ITutorService tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }
        public Tutor CreateTutor(Tutor tutor)
        {
            return _tutorRepository.CreateTutor(tutor);
        }

        public TutorDTO GetTutorByCPF(string cpf)
        {
            var result = TutorQueries.GetTutorByCPF(cpf);

            TutorDTO tutor = new TutorDTO()
            {
                id = result.id,
                documento = result.documento
            };

            return tutor;
        }
    }
}
