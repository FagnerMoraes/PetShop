using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public DonoController(IDonoRepository donoRepository, IMapper mapper)
        {
            _donoRepository = donoRepository;
            _mapper = mapper;
        }

        [HttpGet("consultar-todos")]
        public async Task<ActionResult<IEnumerable<DonoDTO>>> ObterTodos(){
            var donos = await _donoRepository.ObterTodosAsync();                       
            var donoDTO = donos.Select(dono => _mapper.Map<DonoDTO>(dono));           
            return Ok(donoDTO);
        }

        [HttpGet("consultar-nome")]
        public async Task<ActionResult<IEnumerable<DonoDTO>>> ObterPorNome(string nome){
            var donos = await _donoRepository.ObterPorNome(nome);
            var donoDTO = donos.Select(dono => _mapper.Map<DonoDTO>(dono));           
            return Ok(donoDTO);
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<Dono>> CadastrarDono([FromBody]DonoDTO donoDTO){
            var dono = _mapper.Map<Dono>(donoDTO);
            await _donoRepository.AdicionarAsync(dono);
            return Ok();
        }

    }
}