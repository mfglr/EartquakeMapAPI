namespace Core.Models
{
    public abstract class User : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
