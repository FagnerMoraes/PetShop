using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Api.DTO;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonoController : ControllerBase
    {
        private readonly IDonoRepository _donoRepository;

        public DonoController(IDonoRepository donoRepository)
        {
            _donoRepository = donoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dono>>> ObterPorNome(string nome){
            var donos = (object)await _donoRepository.ObterPorNome(nome);
            return Ok(donos);
        }

        [HttpPost]
        public async Task<ActionResult<Dono>> CadastrarDono([FromBody]DonoDTO donodto){
            var dono = DonoDTO.ConvertParaDono(donodto);
            await _donoRepository.AdicionarAsync(dono);
            return Ok();
        }

    }
}