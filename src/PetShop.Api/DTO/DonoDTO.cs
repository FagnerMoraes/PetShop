using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Domain.Entities;
using PetShop.Domain.ValueObjects;

namespace PetShop.Api.DTO
{
    public class DonoDTO
    {
        public int Id { get; set; }
        public NomeDTO Nome { get; set; }
        public string Telefone { get; set; }
        public EnderecoDTO Endereco { get;set; }

    }
}