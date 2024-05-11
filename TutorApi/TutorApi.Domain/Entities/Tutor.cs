using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TutorApi.Domain.Entities
{
    public class Tutor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateOnly dataNasc { get; set; }
        public string email { get; set; }
        public string documento { get; set; }
    }
}
