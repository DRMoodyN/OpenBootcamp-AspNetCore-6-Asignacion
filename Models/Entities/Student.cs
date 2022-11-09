using System;

namespace  Models.Entities
{
    public class Student : BaseEntity
    {
        [Required]
        public string StudentName { get; set; } = null!;
        [Required]
        public DateTime FechaNacimiento { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
