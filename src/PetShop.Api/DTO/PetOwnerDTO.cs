using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Domain.Entities;
using PetShop.Domain.ValueObjects;

namespace PetShop.Api.DTO
{
    public class PetOwnerDTO
    {
        public int Id { get; set; }
        public NameDTO? Name { get; set; }
        public string? CellPhone { get; set; }
        public AdressDTO? Adress { get;set; }

    }
}