
namespace Core.Models
{
    public class Disease :Entity
    {
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Individual> Individuals { get; set; }

    }
}
