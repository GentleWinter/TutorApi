using System.ComponentModel.DataAnnotations;

namespace Tutor.Domain.Entities
{
    public class TutorEntity
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public string Name { get; set; }
        [Key]
        public DateOnly BirthDate { get; set; }
        [Key]
        public string Email { get; set; }
        [Key]
        public string Document { get; set; }
        [Key]
        public string Password { get; set; }
    }
}
