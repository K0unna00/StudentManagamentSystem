namespace FinalAgain.Models
{
    public class RegisterRequest
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
