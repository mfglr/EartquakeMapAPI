namespace Core.Models
{
    public class Business : User
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
