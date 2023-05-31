namespace Core.Models
{
    public class Address : Entity
    {
        public string PlaceId { get; set; }

        public Business Business { get; set; }
    }
}
