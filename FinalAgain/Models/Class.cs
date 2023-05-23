using System.Collections.Generic;

namespace FinalAgain.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credit { get; set; }
        public string? TeacherId { get; set; }
        public int? TypeOfCourseId { get; set; }
        public int? SemesterId { get; set; }
        public Semester Semester { get; set; }
        public AppUser Teacher { get; set; }
        public TypeOfCourse TypeOfCourse { get; set; }

        public List<StudentClass> StudentClasses { get; set; } = new List<StudentClass>();
    }
}
