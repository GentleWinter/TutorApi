using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.Application.Services.Interfaces;
using Tutor.Domain.DTO;
using Tutor.Domain.Entities;

namespace Tutor.Application.Services
{
    public class TutorServices : ITutorService
    {

        public TutorDTO CreateTutor(TutorEntity tutor)
        {
            return CreateTutor(tutor);
        }

        public TutorDTO SearchTutor(TutorDTO tutor)
        {
            //var result = TutorQueries.GetTutor(tutor);

            //TutorDTO tutor = new TutorDTO()
            //{
            //    id = result.id,
            //    documento = result.documento
            //};

            return tutor;
        }
    }
}
