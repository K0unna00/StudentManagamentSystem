namespace FinalAgain.Models
{
    public class StudentClass
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string StudentId { get; set; }
        public AppUser Student { get; set; }
        public Class Class { get; set; }

    }
}
