using System.ComponentModel.DataAnnotations;

namespace Tutor.Domain.Entities
{
    public class TutorEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string Password { get; set; }
    }
}
