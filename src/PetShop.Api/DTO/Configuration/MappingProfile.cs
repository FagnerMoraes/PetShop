using AutoMapper;
using PetShop.Domain.Entities;
using PetShop.Domain.ValueObjects;

namespace PetShop.Api.DTO.Configuration;
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
        CreateMap<Dono, DonoDTO>().ReverseMap();
        CreateMap<Nome, NomeDTO>().ReverseMap();
        CreateMap<Endereco, EnderecoDTO>().ReverseMap();

    }
    }
