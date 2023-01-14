using AutoMapper;
using PetShop.Domain.Entities;
using PetShop.Domain.ValueObjects;

namespace PetShop.Api.DTO.Configuration;
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
        CreateMap<PetOwner, PetOwnerDTO>().ReverseMap();
        CreateMap<Name, NameDTO>().ReverseMap();
        CreateMap<Adress, AdressDTO>().ReverseMap();

    }
    }
