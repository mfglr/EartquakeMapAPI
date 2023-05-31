using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class IndividualWithDiseasesDto : UserDto
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public IEnumerable<DiseaseDto> Diseases { get; set; }
    }
}
