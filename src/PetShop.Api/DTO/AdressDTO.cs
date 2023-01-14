using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Api.DTO
{
    public class AdressDTO
    {
        public string? Street { get; set; }
        public string? District { get; set; }
        public string? HouseNumber { get; set; }
        public string? ZipCode { get; set; }
    }
}