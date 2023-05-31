namespace Core.DTOs
{
    public abstract class UserDto : EntityDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
