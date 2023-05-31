using Core.Models;

namespace Core.DTOs
{
    public class ProductWithCategoriesDto : EntityDto
    {
        public string Name { get; set; }
        public IEnumerable<CategoryDto> Categories { get; set; }
    }
}
