namespace Core.Models
{
    public class Individual : User
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }

        public IEnumerable<Disease> Diseases { get; set; }
    }
}
