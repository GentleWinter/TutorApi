using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TutorApi.Domain.DTO;
using TutorApi.Domain.Entities;

namespace TutorApi.Application.Queries
{
    public class TutorQueries
    {
        public static Tutor GetTutorByCPF(string cpf)
        {
            using (var context = new TutorContext())
            {
                try
                {
                    var result = from b in context.Tutor
                                 .Where(b.cpf == cpf)
                                 select b;

                    if (result.Should().NotBeNull() && result.Should().HaveCount(1))
                    {
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
