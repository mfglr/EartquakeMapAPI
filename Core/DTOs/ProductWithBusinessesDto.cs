namespace Core.DTOs
{
    public class ProductWithBusinessesDto :EntityDto
    {
        public string Name { get; set; }
        public IEnumerable<BusinessDto> Businesses{ get; set; }
    }
}
