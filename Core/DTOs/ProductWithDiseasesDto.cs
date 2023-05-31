using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ProductWithDiseasesDto
    {
        public string Name { get; set; }
        public IEnumerable<DiseaseDto> Diseases { get; set; }
    }
}
