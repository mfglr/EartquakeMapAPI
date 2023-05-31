using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class AddressWithBusinessDto : EntityDto
    {
        public string PlaceId { get; set; }
        public BusinessDto Business { get; set; }
    }
}
