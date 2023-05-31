namespace Core.DTOs
{
    public class DiseaseWithIndividualDto : EntityDto
    {
        public string Name { get; set; }
        public IEnumerable<IndividualDto> Individuals { get; set; }
    }
}
