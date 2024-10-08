﻿namespace Tutor.Domain.DTO
{
    public class TutorDto
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
