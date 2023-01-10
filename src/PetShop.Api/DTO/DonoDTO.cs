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
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }

        public static Dono ConvertParaDono(DonoDTO dono){
            return new Dono(
                dono.Id,
                new Nome(dono.Nome, dono.SobreNome),                
                dono.Telefone,
                new Endereco(dono.Rua,dono.Bairro,dono.Numero,dono.Cep)
            );
        }
    }
}