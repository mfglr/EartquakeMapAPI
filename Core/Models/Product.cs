namespace Core.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public IEnumerable<Product> Components { get; set; }

        public IEnumerable<Category> Categories{ get; set; }

        public IEnumerable<Business> Businesses { get; set; }

        public IEnumerable<Disease> Diseases { get; set; }
    }
}
