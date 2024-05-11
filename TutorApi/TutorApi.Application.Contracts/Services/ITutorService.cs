using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorApi.Domain.DTO;
using TutorApi.Domain.Entities;

namespace TutorApi.Application.Contracts.Services
{
    public interface ITutorService
    {
        TutorDTO GetTutorByCPF(string cpf);

        Tutor CreateTutor(Tutor tutor);
    }
}
