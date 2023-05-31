using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class BusinessWithAddressDto : UserDto
    {
        public string Name { get; set; }
        public AddressDto Address { get; set; }
    }
}
